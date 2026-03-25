using AgendaApi.Data;
using AgendaApi.Models;
using AgendaApi.Hubs;


using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authentication;
var builder = WebApplication.CreateBuilder(args);

//*********CARGAMOS LA BASE DE DATOS********
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddCors(options => {
    options.AddPolicy("PermitirTodo", policy => {
        policy.WithOrigins("http://localhost:5183") // La URL de tu Web según la imagen
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});


builder.Services.AddIdentityApiEndpoints<Usuario>()
    .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();
//NOTIFICAIONES
builder.Services.AddSignalR();
builder.Services.AddSingleton<IUserIdProvider, NameUserIdProvider>();

// --- PARA RESPETAR LOS PUNTOS DE GOOGLE MAPS---
var cultureInfo = new CultureInfo("en-US"); // Cultura que usa punto decimal
cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
// ------------------------


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirTodo");
app.UseRouting();
app.UseHttpsRedirection();



app.UseStaticFiles();

app.Use(async (context, next) =>
{
    var accessToken = context.Request.Query["access_token"];
    var path = context.Request.Path;

    if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/notificacionHub"))
    {
        context.Request.Headers.Authorization = $"Bearer {accessToken}";
    }
    await next();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapGroup("/auth").MapIdentityApi<Usuario>();
app.MapHub<NotificacionHub>("/notificacionHub");
app.MapControllers();


var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}



// Notificaicones
public class NameUserIdProvider : IUserIdProvider
{
    public string? GetUserId(HubConnectionContext connection)
    {
        return connection.User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
    }
}


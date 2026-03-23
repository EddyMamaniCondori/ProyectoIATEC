var builder = WebApplication.CreateBuilder(args);

// 1. Agregamos el cliente para hablar con la API (Backend)
builder.Services.AddHttpClient("AgendaApi", client =>
{
    // IMPORTANTE: Asegúrate de que el puerto (5188) coincida con tu API
    client.BaseAddress = new Uri("http://localhost:5188/"); 
});

// --- NUEVO: Configuración de Autenticación ---
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.Cookie.Name = "Agenda_Session";
        options.LoginPath = "/Account/Login"; // Si no hay sesión, manda aquí
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromHours(8); // Duración de la sesión
    });

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// 2. Aquí es donde Bootstrap y AdminLTE servirán sus archivos
app.UseStaticFiles();

// --- NUEVO: El orden aquí es SAGRADO ---
app.UseAuthentication(); // Primero: ¿Quién eres?
app.UseAuthorization();  // Segundo: ¿Qué puedes hacer?

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}")
    .WithStaticAssets();
app.Run();

using Microsoft.AspNetCore.Mvc;
using AgendaWeb.Models;
using System.Text.Json;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AgendaWeb.Controllers;

public class AccountController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory; //cliente que viaja al froent y backend
    public required string AccessToken { get; set; }
    public required string TokenType { get; set; }
    public required string RefreshToken { get; set; }

    public AccountController(IHttpClientFactory httpClientFactory) //constructor del cliente
    {
        _httpClientFactory = httpClientFactory;
    }

    // 1. Login
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    // 2. 
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var client = _httpClientFactory.CreateClient("AgendaApi");
        var json = JsonSerializer.Serialize(model);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try 
        {
            var response = await client.PostAsync("auth/login", content);
            //return Json(response);

            //var jsonContent1 = await response.Content.ReadAsStringAsync();
            //return Content(jsonContent1, "application/json");

            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                
                var loginData = JsonSerializer.Deserialize<LoginResponse>(jsonContent, new JsonSerializerOptions { 
                    PropertyNameCaseInsensitive = true 
                });


                if (loginData == null || string.IsNullOrEmpty(loginData.AccessToken))
                {
                    ModelState.AddModelError("", "La API no devolvió un accessToken.");
                    return View(model);
                }

       
                Response.Cookies.Append("AuthToken", loginData.AccessToken, new CookieOptions { 
                    HttpOnly = true, 
                    Expires = DateTimeOffset.UtcNow.AddHours(1) 
                });

                // 2. CREAR LA IDENTIDAD
                var claims = new List<Claim>
                {
         
                    new Claim(ClaimTypes.Name, model.Email), 
                    new Claim(ClaimTypes.Email, model.Email),
                    new Claim("Token", loginData.AccessToken)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "MyCookieAuth");
                
                await HttpContext.SignInAsync("MyCookieAuth", new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home"); 
            }
            else
            {
                ViewBag.ErrorLogin = "Correo o contraseña incorrectos.";
                ViewBag.MantenerAbierta = true; 
                return View(model);
            }
        }
        catch (HttpRequestException)
        {
            ModelState.AddModelError("", "No se pudo conectar con el servidor (API). Verifica que esté encendido.");
            return View(model);
        }

        ModelState.AddModelError("", "Correo o contraseña incorrectos.");
        return View(model);
    }
    [HttpPost]
    [ValidateAntiForgeryToken] 
    public async Task<IActionResult> Logout()
    {

        await HttpContext.SignOutAsync("MyCookieAuth");

     
        Response.Cookies.Delete("AuthToken");

  
        return RedirectToAction("Login", "Account");
    }

    [HttpPost]
public async Task<IActionResult> Register(RegisterViewModel model)
{

    Console.WriteLine($"DEBUG: Intentando registrar a {model.Nombre} con el correo {model.Email}");

    if (!ModelState.IsValid) {
        Console.WriteLine("DEBUG: El modelo no es válido según las anotaciones [Required]");
        ViewBag.MantenerAbierta = true;
        return View("Login", model);
    }

    var client = _httpClientFactory.CreateClient("AgendaApi");
    

    Console.WriteLine($"DEBUG: La URL base de la API es: {client.BaseAddress}");

    try 
    {

        Console.WriteLine("DEBUG: Enviando POST a auth/register...");
        var response = await client.PostAsJsonAsync("auth/register", model);

        Console.WriteLine($"DEBUG: Respuesta de la API: {response.StatusCode}");

        if (response.IsSuccessStatusCode) {
             ViewBag.Success = "¡Registrado!";
             ViewBag.MantenerAbierta = true;
             return View("Login");
        }
        
        var error = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"DEBUG: Error detallado de la API: {error}");
        ViewBag.ErrorRegister = error;
    }
    catch (Exception ex) {
        Console.WriteLine($"DEBUG: ¡EXPLOTÓ! Mensaje: {ex.Message}");
    }

    ViewBag.MantenerAbierta = true;
    return View("Login", model);
}

}


public class LoginResponse
{

    public string AccessToken { get; set; }
    public string TokenType { get; set; }
    public int ExpiresIn { get; set; }
    public string RefreshToken { get; set; }
}
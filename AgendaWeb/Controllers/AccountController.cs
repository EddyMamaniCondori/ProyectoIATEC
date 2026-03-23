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

                // Validamos AccessToken (que es el nombre real en tu JSON)
                if (loginData == null || string.IsNullOrEmpty(loginData.AccessToken))
                {
                    ModelState.AddModelError("", "La API no devolvió un accessToken.");
                    return View(model);
                }

                // 1. Guardamos el Token (Usando loginData.AccessToken)
                Response.Cookies.Append("AuthToken", loginData.AccessToken, new CookieOptions { 
                    HttpOnly = true, 
                    Expires = DateTimeOffset.UtcNow.AddHours(1) 
                });

                // 2. CREAR LA IDENTIDAD
                var claims = new List<Claim>
                {
                    // Como la API no mandó UserName, usamos el Email del modelo de login
                    new Claim(ClaimTypes.Name, model.Email), 
                    new Claim(ClaimTypes.Email, model.Email),
                    new Claim("Token", loginData.AccessToken)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "MyCookieAuth");
                
                await HttpContext.SignInAsync("MyCookieAuth", new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home"); 
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
    [ValidateAntiForgeryToken] // Protege contra ataques CSRF
    public async Task<IActionResult> Logout()
    {
        // 1. Cerramos la sesión en el middleware de .NET (Borra la identidad)
        await HttpContext.SignOutAsync("MyCookieAuth");

        // 2. Borramos manualmente tu cookie del Token por si acaso
        Response.Cookies.Delete("AuthToken");

        // 3. Redirigimos al Login (al cuaderno de madera)
        return RedirectToAction("Login", "Account");
    }

}


public class LoginResponse
{
    // Usamos accessToken porque así lo manda tu API
    public string AccessToken { get; set; }
    public string TokenType { get; set; }
    public int ExpiresIn { get; set; }
    public string RefreshToken { get; set; }
}
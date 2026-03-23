using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Controllers
{
    [Authorize]
    public class EventosController : Controller
    {
        public IActionResult Index()
        {
            var token = User.FindFirst("Token")?.Value;
            ViewBag.Token = token;
            // Por ahora solo devolvemos la vista
            return View();
        }
    }
}
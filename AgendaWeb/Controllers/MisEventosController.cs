using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Controllers // Asegúrate que el namespace sea el de tu proyecto Web
{
    public class MisEventosController : Controller
    {
        // Solo devuelve la vista Index.cshtml
        public IActionResult Index()
        {
            return View();
        }
    }
}
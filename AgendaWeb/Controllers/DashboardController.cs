using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace AgendaApi.Controllers;

[Authorize] 
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
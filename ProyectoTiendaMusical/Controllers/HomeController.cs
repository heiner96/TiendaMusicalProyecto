using Microsoft.AspNetCore.Mvc;

namespace ProyectoTiendaMusical.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

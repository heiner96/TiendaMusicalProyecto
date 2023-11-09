using Microsoft.AspNetCore.Mvc;

namespace ProyectoTiendaMusical.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

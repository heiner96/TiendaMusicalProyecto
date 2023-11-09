using Microsoft.AspNetCore.Mvc;

namespace ProyectoTiendaMusical.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

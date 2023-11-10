using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoTiendaMusical.DataBaseContext;
using ProyectoTiendaMusical.Models;

namespace ProyectoTiendaMusical.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ProductosController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Productos
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_context.sp_GetAllProductos());
                       
        }

        // GET: Productos/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || id == 0 || id <= 0)
            {
                return NotFound();
            }

            var producto = _context.sp_GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Precio,Marca,MontoDescuento,RutaImage,Estado")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.sp_InsertProducto(producto);
               
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0 || id <= 0)
            {
                return NotFound();
            }

            var producto = _context.sp_GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Precio,Marca,MontoDescuento,RutaImage,Estado")] Producto producto)
        {
            if (id == null || id == 0 || id <= 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.sp_UpdateProducto(id, producto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0 || id <= 0)
            {
                return NotFound();
            }

            var producto = _context.sp_GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (id == null || id == 0 || id <= 0)
            {
                return Problem("Este producto no existe.");
            }
            var producto =
                _context.sp_GetProducto(id);
            if (producto != null)
            {
                _context.sp_DeleteProducto(id);
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}

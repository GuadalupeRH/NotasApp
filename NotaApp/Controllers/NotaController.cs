using BussinessLayer.Interfaces;
using DataAccessLayer.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace NotaApp.Controllers
{
    public class NotaController : Controller
    {
        private readonly INotaServicio _notaServicio;

        public NotaController(INotaServicio notaService)
        {
            _notaServicio = notaService;
        }
        public async Task<IActionResult>Index()
        {
            var notas = await _notaServicio.GetAll();
            return View(notas);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Nota nota)
        {
            if (!ModelState.IsValid)
                return View(nota);

            await _notaServicio.Create(nota);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Editar(int id)
        {
            var nota = await _notaServicio.GetById(id);
            if (nota == null) return NotFound();

            return View(nota);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Nota nota)
        {
            if (!ModelState.IsValid) return View(nota);

            await _notaServicio.Update(nota);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Eliminar(int id)
        {
            var nota = await _notaServicio.GetById(id);
            if (nota == null) return NotFound();

            return View(nota);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmacionEliminar(int id)
        {
            await _notaServicio.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}

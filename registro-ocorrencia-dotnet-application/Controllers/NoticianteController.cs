using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroOcorrencias.Data;
using RegistroOcorrencias.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOcorrencias.Controllers
{
    public class NoticianteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NoticianteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var noticiantes = from n in _context.Noticiantes select n;

            if (!string.IsNullOrEmpty(searchString))
            {
                noticiantes = noticiantes.Where(n => n.NomeCompleto.Contains(searchString));
            }

            return View(await noticiantes.ToListAsync());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Noticiante noticiante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(noticiante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noticiante);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var noticiante = await _context.Noticiantes.FindAsync(id);
            if (noticiante == null) return NotFound();
            return View(noticiante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Noticiante noticiante)
        {
            if (id != noticiante.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(noticiante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noticiante);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var noticiante = await _context.Noticiantes.FindAsync(id);
            if (noticiante == null) return NotFound();
            return View(noticiante);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var noticiante = await _context.Noticiantes.FindAsync(id);
            if (noticiante != null)
            {
                _context.Noticiantes.Remove(noticiante);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var noticiante = await _context.Noticiantes.FindAsync(id);
            if (noticiante == null) return NotFound();
            return View(noticiante);
        }
    }
}

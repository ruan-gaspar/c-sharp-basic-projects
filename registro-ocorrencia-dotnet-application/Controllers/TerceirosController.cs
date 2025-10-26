using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroOcorrencias.Data;
using RegistroOcorrencias.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOcorrencias.Controllers
{
    public class TerceirosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TerceirosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var terceiros = from t in _context.Terceiros select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                terceiros = terceiros.Where(t => t.NomeCompleto.Contains(searchString));
            }

            return View(await terceiros.ToListAsync());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Terceiros terceiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(terceiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(terceiro);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var terceiro = await _context.Terceiros.FindAsync(id);
            if (terceiro == null) return NotFound();
            return View(terceiro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Terceiros terceiro)
        {
            if (id != terceiro.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(terceiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(terceiro);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var terceiro = await _context.Terceiros.FindAsync(id);
            if (terceiro == null) return NotFound();
            return View(terceiro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var terceiro = await _context.Terceiros.FindAsync(id);
            if (terceiro != null)
            {
                _context.Terceiros.Remove(terceiro);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var terceiro = await _context.Terceiros.FindAsync(id);
            if (terceiro == null) return NotFound();
            return View(terceiro);
        }
    }
}

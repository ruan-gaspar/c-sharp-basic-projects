using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroOcorrencias.Data;
using RegistroOcorrencias.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOcorrencias.Controllers
{
    public class DelegaciaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DelegaciaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var delegacias = from d in _context.Delegacias select d;

            if (!string.IsNullOrEmpty(searchString))
            {
                delegacias = delegacias.Where(d => d.Titulo.Contains(searchString));
            }

            return View(await delegacias.ToListAsync());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Delegacia delegacia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delegacia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(delegacia);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var delegacia = await _context.Delegacias.FindAsync(id);
            if (delegacia == null) return NotFound();
            return View(delegacia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Delegacia delegacia)
        {
            if (id != delegacia.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(delegacia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(delegacia);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var delegacia = await _context.Delegacias.FindAsync(id);
            if (delegacia == null) return NotFound();
            return View(delegacia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var delegacia = await _context.Delegacias.FindAsync(id);
            if (delegacia != null)
            {
                _context.Delegacias.Remove(delegacia);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var delegacia = await _context.Delegacias.FindAsync(id);
            if (delegacia == null) return NotFound();
            return View(delegacia);
        }
    }
}

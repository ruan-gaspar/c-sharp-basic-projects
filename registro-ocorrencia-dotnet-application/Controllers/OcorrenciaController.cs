using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroOcorrencias.Data;
using RegistroOcorrencias.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOcorrencias.Controllers
{
    public class OcorrenciaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OcorrenciaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var ocorrencias = from o in _context.Ocorrencias select o;

            if (!string.IsNullOrEmpty(searchString))
            {
                ocorrencias = ocorrencias.Where(o => o.Titulo.Contains(searchString));
            }

            return View(await ocorrencias.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.StatusList = Enum.GetValues(typeof(StatusOcorrencia));
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ocorrencia ocorrencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocorrencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.StatusList = Enum.GetValues(typeof(StatusOcorrencia));
            return View(ocorrencia);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);
            if (ocorrencia == null) return NotFound();

            ViewBag.StatusList = Enum.GetValues(typeof(StatusOcorrencia));
            return View(ocorrencia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Ocorrencia ocorrencia)
        {
            if (id != ocorrencia.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(ocorrencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.StatusList = Enum.GetValues(typeof(StatusOcorrencia));
            return View(ocorrencia);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);
            if (ocorrencia == null) return NotFound();
            return View(ocorrencia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);
            if (ocorrencia != null) 
            {
                _context.Ocorrencias.Remove(ocorrencia);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);
            if (ocorrencia == null) return NotFound();
            return View(ocorrencia);
        }
    }
}

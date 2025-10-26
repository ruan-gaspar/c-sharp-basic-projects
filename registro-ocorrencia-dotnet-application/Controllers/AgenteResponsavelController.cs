using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroOcorrencias.Data;
using RegistroOcorrencias.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOcorrencias.Controllers
{
    public class AgenteResponsavelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AgenteResponsavelController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var agentes = from a in _context.AgentesResponsaveis select a;

            if (!string.IsNullOrEmpty(searchString))
            {
                agentes = agentes.Where(a => a.NomeCompleto.Contains(searchString));
            }

            return View(await agentes.ToListAsync());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AgenteResponsavel agente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agente);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var agente = await _context.AgentesResponsaveis.FindAsync(id);
            if (agente == null) return NotFound();
            return View(agente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AgenteResponsavel agente)
        {
            if (id != agente.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(agente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agente);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var agente = await _context.AgentesResponsaveis.FindAsync(id);
            if (agente == null) return NotFound();
            return View(agente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var agente = await _context.AgentesResponsaveis.FindAsync(id);
            if (agente != null)
            {
                _context.AgentesResponsaveis.Remove(agente);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var agente = await _context.AgentesResponsaveis.FindAsync(id);
            if (agente == null) return NotFound();
            return View(agente);
        }
    }
}

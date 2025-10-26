using Microsoft.AspNetCore.Mvc;
using RegistroOcorrencias.Models;

namespace RegistroOcorrencias.Controllers
{
    public class OcorrenciaController : Controller
    {
        // Aqui você implementaria seu DbContext para acessar o banco
        // private readonly AppDbContext _context;
        // public OcorrenciaController(AppDbContext context) => _context = context;

        public IActionResult Index()
        {
            // Exemplo: List<Ocorrencia> ocorrencias = _context.Ocorrencias.ToList();
            return View(/*ocorrencias*/);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ocorrencia model)
        {
            if (ModelState.IsValid)
            {
                // _context.Ocorrencias.Add(model);
                // _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // Edit, Details, Delete podem ser implementados de forma similar
    }
}
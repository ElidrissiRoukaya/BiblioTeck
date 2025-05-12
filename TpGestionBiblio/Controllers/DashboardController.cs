using Microsoft.AspNetCore.Mvc;
using TpGestionBiblio.Models;
using TpGestionBiblio.Data;
namespace TpGestionBiblio.Controllers
{
    public class DashboardController : Controller
    {
        private readonly BiblioDbContext _context;

        public DashboardController(BiblioDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                NombreLivres = _context.Livres.Count(),
                NombreAbonnes = _context.Abonnes.Count(),
                NombreEmprunts = _context.Emprunts.Count()
            };

            return View(model);
        }
    }
}

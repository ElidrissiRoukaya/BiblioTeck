using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TpGestionBiblio.Models;

namespace TpGestionBiblio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

<<<<<<< HEAD

=======
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD

        public IActionResult Home()
        {
            return View();
        }
        
        
=======
        public IActionResult dashboard()
        {
            return View();
        }
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        public IActionResult LivresDisponibles()
        {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
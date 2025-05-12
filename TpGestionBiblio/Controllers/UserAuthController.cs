using Microsoft.AspNetCore.Mvc;
using TpGestionBiblio.Models;
using TpGestionBiblio.Data;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace TpGestionBiblio.Controllers
{
    [Route("AdminAuth")]
    public class UserAuthController : Controller
    {
        private readonly BiblioDbContext _context;

        private readonly string adminUsername = "admin";
        private readonly string adminPassword = "admin123";

        public UserAuthController(BiblioDbContext context)
        {
            _context = context;
        }

        // Affiche la page de connexion
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        // Traitement du formulaire de connexion
        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            // Authentification admin
            if (username == adminUsername && password == adminPassword)
            {
                HttpContext.Session.SetString("Role", "Admin");
                HttpContext.Session.SetString("Username", username);
                return RedirectToAction("Index", "Dashboard"); 
            }

            // Authentification abonné
            var abonne = _context.Abonnes
                .FirstOrDefault(a => a.Username == username && a.Password == password);

            if (abonne != null)
            {
                HttpContext.Session.SetString("Role", "Abonne");
                HttpContext.Session.SetInt32("AbonneId", abonne.Id);
                HttpContext.Session.SetString("Username", abonne.Username); 
                return RedirectToAction("Index", "Home"); 
            }

            // Échec de connexion
            ViewBag.Error = "Nom d'utilisateur ou mot de passe incorrect";
            return View();
        }

        // Déconnexion
        [HttpPost("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); 
            return RedirectToAction("Home", "Home"); 
        }
    }
}

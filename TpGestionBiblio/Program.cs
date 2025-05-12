using TpGestionBiblio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TpGestionBiblio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Ajouter les services à la collection pour les contrôleurs et les vues
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession(); 


            // Configuration de la base de données pour utiliser MySQL avec Entity Framework Core
            builder.Services.AddDbContext<BiblioDbContext>(options =>
                options.UseMySql(
                    builder.Configuration.GetConnectionString("TpGestionBiblioConnectionString"),
                    new MySqlServerVersion(new Version(10, 5)) 
                )
            );

            // Ajouter le support de la session (nécessite AddDistributedMemoryCache et AddSession)
            builder.Services.AddDistributedMemoryCache(); // Utilisation de la mémoire pour stocker la session
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Durée d'inactivité avant expiration de la session
                options.Cookie.HttpOnly = true; // Sécurise les cookies
                options.Cookie.IsEssential = true; // Cookie essentiel
            });

            var app = builder.Build();

            // Configuration du pipeline de requêtes HTTP
            if (!app.Environment.IsDevelopment())
            {
                // Environnement de production : gérer les erreurs
                app.UseExceptionHandler("/Home/Error");

                // HSTS (HTTP Strict Transport Security) : activé pour la production
                app.UseHsts();
            }

            // Redirection HTTPS et gestion des fichiers statiques
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Configuration du routage des requêtes
            app.UseRouting();

            // Ajout de la session au pipeline
            app.UseSession();

            app.UseAuthorization();

            // Configuration des routes du contrôleur
           app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Home}/{id?}");


            
            app.MapControllerRoute(
                name: "ListeDisponiblesRoute",
                pattern: "Livres/ListeDisponibles",
                defaults: new { controller = "Livres", action = "ListeDisponibles" });

           app.MapControllerRoute(
               name: "dashboard",
               pattern: "admin/dashboard",
            defaults: new { controller = "Dashboard", action = "Dashboard" });


            // Lancer l'application
            app.Run();
        }
    }
}

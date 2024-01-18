using TpGestionBiblio.Data;
using Microsoft.EntityFrameworkCore;
namespace TpGestionBiblio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Configuration du serveur web


            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BiblioDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("TpGestionBiblioConnectionString")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                 name: "ListeDisponiblesRoute",
        pattern: "Livres/ListeDisponibles",
        defaults: new { controller = "Livres", action = "ListeDisponibles" });

            app.Run();
        }
    }
}
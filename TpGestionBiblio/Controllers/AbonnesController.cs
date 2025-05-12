using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpGestionBiblio.Data;
using TpGestionBiblio.Models; 

namespace TpGestionBiblio.Controllers
{
    public class AbonnesController : Controller
    {
        private readonly BiblioDbContext _context;

        public AbonnesController(BiblioDbContext context)
        {
            _context = context;
        }

        // GET: Abonnes
        public async Task<IActionResult> Index()
        {
            return _context.Abonnes != null ?
                        View(await _context.Abonnes.ToListAsync()) :
                        Problem("Entity set 'BiblioDbContext.Abonnes' is null.");
        }

        // GET: Abonnes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var abonne = await _context.Abonnes.FirstOrDefaultAsync(a => a.Id == id);
            if (abonne == null) return NotFound();

            var emprunts = await _context.Emprunts.Where(e => e.AbonneId == id).ToListAsync();
            ViewData["Emprunts"] = emprunts;

            return View(abonne);
        }

        // GET: Abonnes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Abonnes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Prenom,Username,Password")] Abonne abonne)
        {
            if (ModelState.IsValid)
            {
                _context.Add(abonne);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(abonne);
        }

        // GET: Abonnes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Abonnes == null) return NotFound();

            var abonne = await _context.Abonnes.FindAsync(id);
            if (abonne == null) return NotFound();

            return View(abonne);
        }

        // POST: Abonnes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Prenom,Username,Password")] Abonne abonne)
        {
            if (id != abonne.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(abonne);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AbonneExists(abonne.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(abonne);
        }

        // GET: Abonnes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Abonnes == null) return NotFound();

            var abonne = await _context.Abonnes.FirstOrDefaultAsync(m => m.Id == id);
            if (abonne == null) return NotFound();

            return View(abonne);
        }

        // POST: Abonnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Abonnes == null)
            {
                return Problem("Entity set 'BiblioDbContext.Abonnes' is null.");
            }

            var abonne = await _context.Abonnes.FindAsync(id);
            if (abonne != null)
            {
                _context.Abonnes.Remove(abonne);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbonneExists(int id)
        {
            return (_context.Abonnes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

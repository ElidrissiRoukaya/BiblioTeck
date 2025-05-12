using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpGestionBiblio.Data;
<<<<<<< HEAD
using TpGestionBiblio.Models; 
=======
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04

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
<<<<<<< HEAD
            return _context.Abonnes != null ?
                        View(await _context.Abonnes.ToListAsync()) :
                        Problem("Entity set 'BiblioDbContext.Abonnes' is null.");
=======
              return _context.Abonnes != null ? 
                          View(await _context.Abonnes.ToListAsync()) :
                          Problem("Entity set 'BiblioDbContext.Abonnes'  is null.");
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        }

        // GET: Abonnes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
<<<<<<< HEAD
            if (id == null) return NotFound();

            var abonne = await _context.Abonnes.FirstOrDefaultAsync(a => a.Id == id);
            if (abonne == null) return NotFound();

            var emprunts = await _context.Emprunts.Where(e => e.AbonneId == id).ToListAsync();
            ViewData["Emprunts"] = emprunts;
=======
            if (id == null)
            {
                return NotFound();
            }

            var abonne = await _context.Abonnes.FirstOrDefaultAsync(a => a.Id == id);

            if (abonne == null)
            {
                return NotFound();
            }

            var emprunts = await _context.Emprunts.Where(e => e.AbonneId == id).ToListAsync();

            ViewData["Emprunts"] = emprunts; // Passer les emprunts à la vue
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04

            return View(abonne);
        }

<<<<<<< HEAD
=======

>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        // GET: Abonnes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Abonnes/Create
<<<<<<< HEAD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Prenom,Username,Password")] Abonne abonne)
=======
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Prenom")] Abonne abonne)
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
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
<<<<<<< HEAD
            if (id == null || _context.Abonnes == null) return NotFound();

            var abonne = await _context.Abonnes.FindAsync(id);
            if (abonne == null) return NotFound();

=======
            if (id == null || _context.Abonnes == null)
            {
                return NotFound();
            }

            var abonne = await _context.Abonnes.FindAsync(id);
            if (abonne == null)
            {
                return NotFound();
            }
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
            return View(abonne);
        }

        // POST: Abonnes/Edit/5
<<<<<<< HEAD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Prenom,Username,Password")] Abonne abonne)
        {
            if (id != abonne.Id) return NotFound();
=======
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Prenom")] Abonne abonne)
        {
            if (id != abonne.Id)
            {
                return NotFound();
            }
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04

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

<<<<<<< HEAD
        // GET: Abonnes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Abonnes == null) return NotFound();

            var abonne = await _context.Abonnes.FirstOrDefaultAsync(m => m.Id == id);
            if (abonne == null) return NotFound();
=======
       // GET: Abonnes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Abonnes == null)
            {
                return NotFound();
            }

            var abonne = await _context.Abonnes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (abonne == null)
            {
                return NotFound();
            }
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04

            return View(abonne);
        }

        // POST: Abonnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Abonnes == null)
            {
<<<<<<< HEAD
                return Problem("Entity set 'BiblioDbContext.Abonnes' is null.");
            }

=======
                return Problem("Entity set 'BiblioDbContext.Abonnes'  is null.");
            }
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
            var abonne = await _context.Abonnes.FindAsync(id);
            if (abonne != null)
            {
                _context.Abonnes.Remove(abonne);
            }
<<<<<<< HEAD

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbonneExists(int id)
        {
            return (_context.Abonnes?.Any(e => e.Id == id)).GetValueOrDefault();
=======
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       
        private bool AbonneExists(int id)
        {
          return (_context.Abonnes?.Any(e => e.Id == id)).GetValueOrDefault();
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        }
    }
}

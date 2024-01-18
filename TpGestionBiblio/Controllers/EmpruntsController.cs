using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpGestionBiblio.Data;

namespace TpGestionBiblio.Controllers
{
    public class EmpruntsController : Controller
    {
        private readonly BiblioDbContext _context;

        public EmpruntsController(BiblioDbContext context)
        {
            _context = context;
        }

        // GET: Emprunts
        public async Task<IActionResult> Index()
        {
              return _context.Emprunts != null ? 
                          View(await _context.Emprunts.ToListAsync()) :
                          Problem("Entity set 'BiblioDbContext.Emprunts'  is null.");
        }

        // GET: Emprunts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Emprunts == null)
            {
                return NotFound();
            }

            var emprunt = await _context.Emprunts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprunt == null)
            {
                return NotFound();
            }

            return View(emprunt);
        }

        // GET: Emprunts/Create
        public IActionResult Create()
        {
            return View();
        }
      
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LivreId,AbonneId,DateEmprunt,DateRetour")] Emprunt emprunt)
        {
            if (ModelState.IsValid)
            {
                var livre = await _context.Livres.FindAsync(emprunt.LivreId);
                var abonne = await _context.Abonnes.FindAsync(emprunt.AbonneId);

                // Vérifier si le livre existe et s'il est disponible
                if (livre != null && !livre.EstEmprunte)
                {
                    // Vérifier si l'abonné a déjà emprunté 2 livres non retournés
                    var nbEmpruntsNonRetournes = _context.Emprunts.Count(e => e.AbonneId == emprunt.AbonneId && e.DateRetour == null);
                    if (nbEmpruntsNonRetournes < 2)
                    {
                        // Calculer la date de retour dans 2 semaines
                        var dateRetour = DateTime.Now.AddDays(14);

                        // Vérifier si la date de retour ne dépasse pas 2 semaines
                        if (dateRetour <= DateTime.Now.AddDays(14))
                        {
                            // Mettre à jour les informations d'emprunt
                            emprunt.DateEmprunt = DateTime.Now;
                            emprunt.DateRetour = dateRetour;

                            // Marquer le livre comme emprunté
                            livre.EstEmprunte = true;

                            // Ajouter l'emprunt et sauvegarder les modifications
                            _context.Add(emprunt);
                            await _context.SaveChangesAsync();

                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "La durée de l'emprunt ne peut pas dépasser 2 semaines.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Limite d'emprunts atteinte pour cet abonné.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ce livre n'est pas disponible pour l'emprunt.");
                }
            }

            return View(emprunt);
        }

        public IActionResult ApresEmprunte()
        {
            return View();
        }

        public IActionResult EmprunterLivre()
        {
            return View();
        }

        /// <summary>
        /// empreinter( user)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmprunterLivre([Bind("Id,LivreId,AbonneId,DateEmprunt,DateRetour")] Emprunt emprunt)
        {
            if (ModelState.IsValid)
            {
                var livre = await _context.Livres.FindAsync(emprunt.LivreId);
                var abonne = await _context.Abonnes.FindAsync(emprunt.AbonneId);

                // Vérifier si le livre existe et s'il est disponible
                if (livre != null && !livre.EstEmprunte)
                {
                    // Vérifier si l'abonné a déjà emprunté 2 livres non retournés
                    var nbEmpruntsNonRetournes = _context.Emprunts.Count(e => e.AbonneId == emprunt.AbonneId && e.DateRetour == null);
                    if (nbEmpruntsNonRetournes < 2)
                    {
                        // Calculer la date de retour dans 2 semaines
                        var dateRetour = DateTime.Now.AddDays(14);

                        // Vérifier si la date de retour ne dépasse pas 2 semaines
                        if (dateRetour <= DateTime.Now.AddDays(14))
                        {
                            // Mettre à jour les informations d'emprunt
                            emprunt.DateEmprunt = DateTime.Now;
                            emprunt.DateRetour = dateRetour;

                            // Marquer le livre comme emprunté
                            livre.EstEmprunte = true;

                            // Ajouter l'emprunt et sauvegarder les modifications
                            _context.Add(emprunt);
                            await _context.SaveChangesAsync();

                            return RedirectToAction(nameof(ApresEmprunte));
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "La durée de l'emprunt ne peut pas dépasser 2 semaines.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Limite d'emprunts atteinte pour cet abonné.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ce livre n'est pas disponible pour l'emprunt.");
                }
            }

            return View(emprunt);
        }
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>


        // GET: Emprunts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Emprunts == null)
            {
                return NotFound();
            }

            var emprunt = await _context.Emprunts.FindAsync(id);
            if (emprunt == null)
            {
                return NotFound();
            }
            return View(emprunt);
        }

        // POST: Emprunts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LivreId,AbonneId,DateEmprunt,DateRetour")] Emprunt emprunt)
        {
            if (id != emprunt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emprunt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpruntExists(emprunt.Id))
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
            return View(emprunt);
        }

        // GET: Emprunts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Emprunts == null)
            {
                return NotFound();
            }

            var emprunt = await _context.Emprunts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprunt == null)
            {
                return NotFound();
            }

            return View(emprunt);
        }

        // POST: Emprunts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Emprunts == null)
            {
                return Problem("Entity set 'BiblioDbContext.Emprunts'  is null.");
            }
            var emprunt = await _context.Emprunts.FindAsync(id);
            if (emprunt != null)
            {
                _context.Emprunts.Remove(emprunt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

     


        //Livres Disponibles
        public async Task<IActionResult> LivresDisponibles()
        {
            var livresDisponibles = await _context.Livres
                .Where(l => !l.EstEmprunte)
                .ToListAsync();

            return View(livresDisponibles);
        }


        private bool EmpruntExists(int id)
        {
          return (_context.Emprunts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

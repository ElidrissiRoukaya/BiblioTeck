﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpGestionBiblio.Data;

namespace TpGestionBiblio.Controllers
{
    public class LivresController : Controller
    {
        private readonly BiblioDbContext _context;

        public LivresController(BiblioDbContext context)
        {
            _context = context;
        }

        // GET: Livres
        public async Task<IActionResult> Index()
        {
              return _context.Livres != null ? 
                          View(await _context.Livres.ToListAsync()) :
                          Problem("Entity set 'BiblioDbContext.Livres'  is null.");
        }

        // GET: Livres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Livres == null)
            {
                return NotFound();
            }

            var livre = await _context.Livres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livre == null)
            {
                return NotFound();
            }

            return View(livre);
        }

        // GET: Livres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Livres/Create
<<<<<<< HEAD
        
=======
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titre,Auteur,Resume,EstEmprunte")] Livre livre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livre);
        }

        // GET: Livres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Livres == null)
            {
                return NotFound();
            }

            var livre = await _context.Livres.FindAsync(id);
            if (livre == null)
            {
                return NotFound();
            }
            return View(livre);
        }

        // POST: Livres/Edit/5
<<<<<<< HEAD
      
=======
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titre,Auteur,Resume,EstEmprunte")] Livre livre)
        {
            if (id != livre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivreExists(livre.Id))
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
            return View(livre);
        }

        // GET: Livres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Livres == null)
            {
                return NotFound();
            }

            var livre = await _context.Livres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livre == null)
            {
                return NotFound();
            }

            return View(livre);
        }

        // POST: Livres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Livres == null)
            {
                return Problem("Entity set 'BiblioDbContext.Livres'  is null.");
            }
            var livre = await _context.Livres.FindAsync(id);
            if (livre != null)
            {
                _context.Livres.Remove(livre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivreExists(int id)
        {
          return (_context.Livres?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

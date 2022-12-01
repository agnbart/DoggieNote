using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoggieNote.Data;
using DoggieNote.Models;

namespace DoggieNote.Controllers
{
    public class CompetitionControllerWithRelations : Controller
    {
        private readonly DoggieDbContext _context;

        public CompetitionControllerWithRelations(DoggieDbContext context)
        {
            _context = context;
        }

        // GET: CompetitionControllerWithRelations
        public async Task<IActionResult> Index()
        {
              return View(await _context.Competitions.ToListAsync());
        }

        // GET: CompetitionControllerWithRelations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Competitions == null)
            {
                return NotFound();
            }

            var competition = await _context.Competitions
                .FirstOrDefaultAsync(m => m.CompetitionId == id);
            if (competition == null)
            {
                return NotFound();
            }

            return View(competition);
        }

        // GET: CompetitionControllerWithRelations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompetitionControllerWithRelations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompetitionId,Name,Place")] Competition competition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(competition);
        }

        // GET: CompetitionControllerWithRelations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Competitions == null)
            {
                return NotFound();
            }

            var competition = await _context.Competitions.FindAsync(id);
            if (competition == null)
            {
                return NotFound();
            }
            return View(competition);
        }

        // POST: CompetitionControllerWithRelations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompetitionId,Name,Place")] Competition competition)
        {
            if (id != competition.CompetitionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetitionExists(competition.CompetitionId))
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
            return View(competition);
        }

        // GET: CompetitionControllerWithRelations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Competitions == null)
            {
                return NotFound();
            }

            var competition = await _context.Competitions
                .FirstOrDefaultAsync(m => m.CompetitionId == id);
            if (competition == null)
            {
                return NotFound();
            }

            return View(competition);
        }

        // POST: CompetitionControllerWithRelations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Competitions == null)
            {
                return Problem("Entity set 'DoggieDbContext.Competitions'  is null.");
            }
            var competition = await _context.Competitions.FindAsync(id);
            if (competition != null)
            {
                _context.Competitions.Remove(competition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetitionExists(int id)
        {
          return _context.Competitions.Any(e => e.CompetitionId == id);
        }
    }
}

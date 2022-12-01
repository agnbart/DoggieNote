using DoggieNote.Data;
using DoggieNote.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoggieNote.Controllers
{
    public class CompetitionControllerWithoutRelations : Controller
    {
        private readonly DoggieDbContext _context;

        public CompetitionControllerWithoutRelations(DoggieDbContext context)
        {
            _context = context;
        }
        // GET: Competitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Competitions.ToListAsync());
        }
        
        // GET: Competitions/Details/5
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


        // GET: Competitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Competitions/Create
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


        // GET: Delete/Delete/5
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

        // POST: Delete/Delete/5
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
    }
}

using Calender_Webapp.Data;
using Calender_Webapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calender_Webapp.Controllers
{
    public class TermineController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TermineController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Termine.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Termin termin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(termin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(termin);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var termin = await _context.Termine.FindAsync(id);
            if (termin != null)
            {
                _context.Termine.Remove(termin);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        } 

    }
}

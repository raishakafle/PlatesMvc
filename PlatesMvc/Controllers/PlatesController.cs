using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlatesMvc.Data;
using PlatesMvc.Models;

namespace PlatesMvc.Controllers
{
    public class PlatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Plates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plates.ToListAsync());
        }

        // GET: Plates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plates = await _context.Plates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plates == null)
            {
                return NotFound();
            }

            return View(plates);
        }

        // GET: Plates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Material,ManufacturedDate,Design,Size,Shape,Function")] Plates plates)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plates);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plates);
        }

        // GET: Plates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plates = await _context.Plates.FindAsync(id);
            if (plates == null)
            {
                return NotFound();
            }
            return View(plates);
        }

        // POST: Plates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Material,ManufacturedDate,Design,Size,Shape,Function")] Plates plates)
        {
            if (id != plates.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plates);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatesExists(plates.Id))
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
            return View(plates);
        }

        // GET: Plates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plates = await _context.Plates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plates == null)
            {
                return NotFound();
            }

            return View(plates);
        }

        // POST: Plates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plates = await _context.Plates.FindAsync(id);
            _context.Plates.Remove(plates);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlatesExists(int id)
        {
            return _context.Plates.Any(e => e.Id == id);
        }
    }
}

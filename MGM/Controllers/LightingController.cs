using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MGM.Data;
using MGM.Models;

namespace MGM.Controllers
{
    public class LightingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LightingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Lighting
        public async Task<IActionResult> LightIndex()
        {
            return View(await _context.Lightings.ToListAsync());
        }

        // GET: Lighting/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lighting = await _context.Lightings
                .FirstOrDefaultAsync(m => m.LightingId == id);
            if (lighting == null)
            {
                return NotFound();
            }

            return View(lighting);
        }

        // GET: Lighting/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lighting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LightingId,Type,Size")] Lighting lighting)
        {
            if (ModelState.IsValid)
            {
                lighting.LightingId = Guid.NewGuid();
                _context.Add(lighting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(LightIndex));
            }
            return View(lighting);
        }

        // GET: Lighting/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lighting = await _context.Lightings.FindAsync(id);
            if (lighting == null)
            {
                return NotFound();
            }
            return View(lighting);
        }

        // POST: Lighting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("LightingId,Type,Size")] Lighting lighting)
        {
            if (id != lighting.LightingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lighting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LightingExists(lighting.LightingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(LightIndex));
            }
            return View(lighting);
        }

        // GET: Lighting/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lighting = await _context.Lightings
                .FirstOrDefaultAsync(m => m.LightingId == id);
            if (lighting == null)
            {
                return NotFound();
            }

            return View(lighting);
        }

        // POST: Lighting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var lighting = await _context.Lightings.FindAsync(id);
            if (lighting != null)
            {
                _context.Lightings.Remove(lighting);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(LightIndex));
        }

        private bool LightingExists(Guid id)
        {
            return _context.Lightings.Any(e => e.LightingId == id);
        }
    }
}

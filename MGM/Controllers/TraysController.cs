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
    public class TraysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TraysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trays
        public async Task<IActionResult> TrayIndex()
        {
            return View(await _context.Trays.ToListAsync());
        }

        // GET: Trays/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tray = await _context.Trays
                .FirstOrDefaultAsync(m => m.TrayId == id);
            if (tray == null)
            {
                return NotFound();
            }

            return View(tray);
        }

        // GET: Trays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrayId,Name")] Tray tray)
        {
            if (ModelState.IsValid)
            {
                tray.TrayId = Guid.NewGuid();
                _context.Add(tray);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TrayIndex));
            }
            return View(tray);
        }

        // GET: Trays/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tray = await _context.Trays.FindAsync(id);
            if (tray == null)
            {
                return NotFound();
            }
            return View(tray);
        }

        // POST: Trays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("TrayId,Name")] Tray tray)
        {
            if (id != tray.TrayId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tray);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrayExists(tray.TrayId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TrayIndex));
            }
            return View(tray);
        }

        // GET: Trays/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tray = await _context.Trays
                .FirstOrDefaultAsync(m => m.TrayId == id);
            if (tray == null)
            {
                return NotFound();
            }

            return View(tray);
        }

        // POST: Trays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tray = await _context.Trays.FindAsync(id);
            if (tray != null)
            {
                _context.Trays.Remove(tray);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(TrayIndex));
        }

        private bool TrayExists(Guid id)
        {
            return _context.Trays.Any(e => e.TrayId == id);
        }
    }
}

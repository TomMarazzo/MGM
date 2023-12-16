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
    public class GrowPlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GrowPlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GrowPlans
        public async Task<IActionResult> GrowPlanIndex()
        {
            return View(await _context.GrowPlans.ToListAsync());
        }

        // GET: GrowPlans/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var growPlan = await _context.GrowPlans
                .FirstOrDefaultAsync(m => m.GrowPlanId == id);
            if (growPlan == null)
            {
                return NotFound();
            }

            return View(growPlan);
        }

        // GET: GrowPlans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GrowPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GrowPlanId")] GrowPlan growPlan)
        {
            if (ModelState.IsValid)
            {
                growPlan.GrowPlanId = Guid.NewGuid();
                _context.Add(growPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GrowPlanIndex));
            }
            return View(growPlan);
        }

        // GET: GrowPlans/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var growPlan = await _context.GrowPlans.FindAsync(id);
            if (growPlan == null)
            {
                return NotFound();
            }
            return View(growPlan);
        }

        // POST: GrowPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("GrowPlanId")] GrowPlan growPlan)
        {
            if (id != growPlan.GrowPlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(growPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrowPlanExists(growPlan.GrowPlanId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(GrowPlanIndex));
            }
            return View(growPlan);
        }

        // GET: GrowPlans/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var growPlan = await _context.GrowPlans
                .FirstOrDefaultAsync(m => m.GrowPlanId == id);
            if (growPlan == null)
            {
                return NotFound();
            }

            return View(growPlan);
        }

        // POST: GrowPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var growPlan = await _context.GrowPlans.FindAsync(id);
            if (growPlan != null)
            {
                _context.GrowPlans.Remove(growPlan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GrowPlanIndex));
        }

        private bool GrowPlanExists(Guid id)
        {
            return _context.GrowPlans.Any(e => e.GrowPlanId == id);
        }
    }
}

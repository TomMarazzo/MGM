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
    public class CostQtyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CostQtyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CostQty
        public async Task<IActionResult> CostQtyIndex()
        {
            return View(await _context.costQties.ToListAsync());
        }

        // GET: CostQty/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costQty = await _context.costQties
                .FirstOrDefaultAsync(m => m.CostQtyId == id);
            if (costQty == null)
            {
                return NotFound();
            }

            return View(costQty);
        }

        // GET: CostQty/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CostQty/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CostQtyId,Price,Qty")] CostQty costQty)
        {
            if (ModelState.IsValid)
            {
                costQty.CostQtyId = Guid.NewGuid();
                _context.Add(costQty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CostQtyIndex));
            }
            return View(costQty);
        }

        // GET: CostQty/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costQty = await _context.costQties.FindAsync(id);
            if (costQty == null)
            {
                return NotFound();
            }
            return View(costQty);
        }

        // POST: CostQty/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CostQtyId,Price,Qty")] CostQty costQty)
        {
            if (id != costQty.CostQtyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(costQty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CostQtyExists(costQty.CostQtyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(CostQtyIndex));
            }
            return View(costQty);
        }

        // GET: CostQty/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costQty = await _context.costQties
                .FirstOrDefaultAsync(m => m.CostQtyId == id);
            if (costQty == null)
            {
                return NotFound();
            }

            return View(costQty);
        }

        // POST: CostQty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var costQty = await _context.costQties.FindAsync(id);
            if (costQty != null)
            {
                _context.costQties.Remove(costQty);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CostQtyIndex));
        }

        private bool CostQtyExists(Guid id)
        {
            return _context.costQties.Any(e => e.CostQtyId == id);
        }
    }
}

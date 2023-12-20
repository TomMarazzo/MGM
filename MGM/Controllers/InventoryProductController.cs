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
    public class InventoryProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InventoryProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InventoryProduct
        public async Task<IActionResult> InventoryProductIndex()
        {
            var applicationDbContext = _context.InventoryProducts.Include(i => i.Supplier);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: InventoryProduct/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryProduct = await _context.InventoryProducts
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(m => m.InventoryProductId == id);
            if (inventoryProduct == null)
            {
                return NotFound();
            }

            return View(inventoryProduct);
        }

        // GET: InventoryProduct/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "CompanyName");
            return View();
        }

        // POST: InventoryProduct/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventoryProductId,SupplierId,Name,Qty,Price,Date")] InventoryProduct inventoryProduct)
        {
            if (ModelState.IsValid)
            {
                inventoryProduct.InventoryProductId = Guid.NewGuid();
                _context.Add(inventoryProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(InventoryProductIndex));
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "CompanyName", inventoryProduct.SupplierId);
            return View(inventoryProduct);
        }

        // GET: InventoryProduct/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryProduct = await _context.InventoryProducts.FindAsync(id);
            if (inventoryProduct == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "CompanyName", inventoryProduct.SupplierId);
            return View(inventoryProduct);
        }

        // POST: InventoryProduct/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("InventoryProductId,SupplierId,Name,Qty,Price,Date")] InventoryProduct inventoryProduct)
        {
            if (id != inventoryProduct.InventoryProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventoryProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryProductExists(inventoryProduct.InventoryProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(InventoryProductIndex));
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "CompanyName", inventoryProduct.SupplierId);
            return View(inventoryProduct);
        }

        // GET: InventoryProduct/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryProduct = await _context.InventoryProducts
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(m => m.InventoryProductId == id);
            if (inventoryProduct == null)
            {
                return NotFound();
            }

            return View(inventoryProduct);
        }

        // POST: InventoryProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var inventoryProduct = await _context.InventoryProducts.FindAsync(id);
            if (inventoryProduct != null)
            {
                _context.InventoryProducts.Remove(inventoryProduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(InventoryProductIndex));
        }

        private bool InventoryProductExists(Guid id)
        {
            return _context.InventoryProducts.Any(e => e.InventoryProductId == id);
        }
    }
}

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
    public class CustomerOrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerOrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerOrder
        public async Task<IActionResult> CustomerOrderIndex()
        {
            var applicationDbContext = _context.CustomerOrder.Include(c => c.Customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerOrder/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrder = await _context.CustomerOrder
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.CustomerOrderId == id);
            if (customerOrder == null)
            {
                return NotFound();
            }

            return View(customerOrder);
        }

        // GET: CustomerOrder/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName");
            return View();
        }

        // POST: CustomerOrder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerOrderId,CustomerId,Qty,OrderDate,Total,OrderStatus")] CustomerOrder customerOrder)
        {
            if (ModelState.IsValid)
            {
                customerOrder.CustomerOrderId = Guid.NewGuid();
                _context.Add(customerOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CustomerOrderIndex));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", customerOrder.CustomerId);
            return View(customerOrder);
        }

        // GET: CustomerOrder/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrder = await _context.CustomerOrder.FindAsync(id);
            if (customerOrder == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", customerOrder.CustomerId);
            return View(customerOrder);
        }

        // POST: CustomerOrder/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CustomerOrderId,CustomerId,Qty,OrderDate,Total,OrderStatus")] CustomerOrder customerOrder)
        {
            if (id != customerOrder.CustomerOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerOrderExists(customerOrder.CustomerOrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(CustomerOrderIndex));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CompanyName", customerOrder.CustomerId);
            return View(customerOrder);
        }

        // GET: CustomerOrder/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrder = await _context.CustomerOrder
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.CustomerOrderId == id);
            if (customerOrder == null)
            {
                return NotFound();
            }

            return View(customerOrder);
        }

        // POST: CustomerOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var customerOrder = await _context.CustomerOrder.FindAsync(id);
            if (customerOrder != null)
            {
                _context.CustomerOrder.Remove(customerOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CustomerOrderIndex));
        }

        private bool CustomerOrderExists(Guid id)
        {
            return _context.CustomerOrder.Any(e => e.CustomerOrderId == id);
        }
    }
}

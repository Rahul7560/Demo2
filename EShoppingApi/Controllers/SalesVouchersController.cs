using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EShoppingApi;
using EShoppingEntity;

namespace EShoppingApi.Controllers
{
    public class SalesVouchersController : Controller
    {
        private readonly AppDbContext _context;

        public SalesVouchersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SalesVouchers
        public async Task<IActionResult> Index()
        {
            return View(await _context.SalesVoucher.ToListAsync());
        }

        // GET: SalesVouchers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesVoucher = await _context.SalesVoucher
                .FirstOrDefaultAsync(m => m.VoucherId == id);
            if (salesVoucher == null)
            {
                return NotFound();
            }

            return View(salesVoucher);
        }

        // GET: SalesVouchers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesVouchers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SalesVoucher salesVoucher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesVoucher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesVoucher);
        }

        // GET: SalesVouchers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesVoucher = await _context.SalesVoucher.FindAsync(id);
            if (salesVoucher == null)
            {
                return NotFound();
            }
            return View(salesVoucher);
        }

        // POST: SalesVouchers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SalesVoucher salesVoucher)
        {
            

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesVoucher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesVoucherExists(salesVoucher.VoucherId))
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
            return View(salesVoucher);
        }

        // GET: SalesVouchers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesVoucher = await _context.SalesVoucher
                .FirstOrDefaultAsync(m => m.VoucherId == id);
            if (salesVoucher == null)
            {
                return NotFound();
            }

            return View(salesVoucher);
        }

        // POST: SalesVouchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesVoucher = await _context.SalesVoucher.FindAsync(id);
            _context.SalesVoucher.Remove(salesVoucher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesVoucherExists(int id)
        {
            return _context.SalesVoucher.Any(e => e.VoucherId == id);
        }
    }
}

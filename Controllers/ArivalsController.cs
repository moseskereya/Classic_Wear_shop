using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Classics_Shop.Data;
using Classics_Shop.Models;

namespace Classics_Shop.Controllers
{
    public class ArivalsController : Controller
    {
        private readonly ProductContext _context;

        public ArivalsController(ProductContext context)
        {
            _context = context;
        }

        // GET: Arivals
        public async Task<IActionResult> Index()
        {
            return View(await _context.arivals.ToListAsync());
        }

        // GET: Arivals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arival = await _context.arivals
                .FirstOrDefaultAsync(m => m.ID == id);
            if (arival == null)
            {
                return NotFound();
            }

            return View(arival);
        }

        // GET: Arivals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Arivals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductName,Description,ImagePath,UnitPrice")] Arival arival)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arival);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arival);
        }

        // GET: Arivals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arival = await _context.arivals.FindAsync(id);
            if (arival == null)
            {
                return NotFound();
            }
            return View(arival);
        }

        // POST: Arivals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,Description,ImagePath,UnitPrice")] Arival arival)
        {
            if (id != arival.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arival);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArivalExists(arival.ID))
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
            return View(arival);
        }

        // GET: Arivals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arival = await _context.arivals
                .FirstOrDefaultAsync(m => m.ID == id);
            if (arival == null)
            {
                return NotFound();
            }

            return View(arival);
        }

        // POST: Arivals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var arival = await _context.arivals.FindAsync(id);
            _context.arivals.Remove(arival);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArivalExists(int id)
        {
            return _context.arivals.Any(e => e.ID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UnderControl.Data;
using UnderControl.Models;

namespace UnderControl.Controllers
{
    public class PeriodDaysModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeriodDaysModelsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: PeriodDaysModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PeriodDaysModels.ToListAsync());
        }
        [Authorize]

        // GET: PeriodDaysModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodDaysModel = await _context.PeriodDaysModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodDaysModel == null)
            {
                return NotFound();
            }

            return View(periodDaysModel);
        }
        [Authorize]

        // GET: PeriodDaysModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PeriodDaysModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddDate")] PeriodDaysModel periodDaysModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periodDaysModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(periodDaysModel);
        }
        [Authorize]
        // GET: PeriodDaysModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodDaysModel = await _context.PeriodDaysModels.FindAsync(id);
            if (periodDaysModel == null)
            {
                return NotFound();
            }
            return View(periodDaysModel);
        }

        // POST: PeriodDaysModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddDate")] PeriodDaysModel periodDaysModel)
        {
            if (id != periodDaysModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(periodDaysModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeriodDaysModelExists(periodDaysModel.Id))
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
            return View(periodDaysModel);
        }
        [Authorize]

        // GET: PeriodDaysModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodDaysModel = await _context.PeriodDaysModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodDaysModel == null)
            {
                return NotFound();
            }

            return View(periodDaysModel);
        }

        // POST: PeriodDaysModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var periodDaysModel = await _context.PeriodDaysModels.FindAsync(id);
            _context.PeriodDaysModels.Remove(periodDaysModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeriodDaysModelExists(int id)
        {
            return _context.PeriodDaysModels.Any(e => e.Id == id);
        }
    }
}

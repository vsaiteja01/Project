﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projectcriczee;

namespace Projectcriczee.Controllers
{
    public class DelhiCapitalsController : Controller
    {
        private readonly CrickzeedbContext _context;

        public DelhiCapitalsController(CrickzeedbContext context)
        {
            _context = context;
        }

        // GET: DelhiCapitals
        public async Task<IActionResult> Index()
        {
            return View(await _context.DelhiCapitals.ToListAsync());
        }

        // GET: DelhiCapitals/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delhiCapital = await _context.DelhiCapitals
                .FirstOrDefaultAsync(m => m.Player == id);
            if (delhiCapital == null)
            {
                return NotFound();
            }

            return View(delhiCapital);
        }

        // GET: DelhiCapitals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DelhiCapitals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlayerId,Player,PlayerRole,Price")] DelhiCapital delhiCapital)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delhiCapital);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(delhiCapital);
        }

        // GET: DelhiCapitals/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delhiCapital = await _context.DelhiCapitals.FindAsync(id);
            if (delhiCapital == null)
            {
                return NotFound();
            }
            return View(delhiCapital);
        }

        // POST: DelhiCapitals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PlayerId,Player,PlayerRole,Price")] DelhiCapital delhiCapital)
        {
            if (id != delhiCapital.Player)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(delhiCapital);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DelhiCapitalExists(delhiCapital.Player))
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
            return View(delhiCapital);
        }

        // GET: DelhiCapitals/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delhiCapital = await _context.DelhiCapitals
                .FirstOrDefaultAsync(m => m.Player == id);
            if (delhiCapital == null)
            {
                return NotFound();
            }

            return View(delhiCapital);
        }

        // POST: DelhiCapitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var delhiCapital = await _context.DelhiCapitals.FindAsync(id);
            _context.DelhiCapitals.Remove(delhiCapital);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DelhiCapitalExists(string id)
        {
            return _context.DelhiCapitals.Any(e => e.Player == id);
        }
    }
}

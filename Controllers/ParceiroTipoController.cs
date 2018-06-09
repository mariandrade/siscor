using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SisCor.Models;

namespace SisCor.Controllers
{
    public class ParceiroTipoController : Controller
    {
        private readonly SisCorContext _context;

        public ParceiroTipoController(SisCorContext context)
        {
            _context = context;
        }

        // GET: ParceiroTipo
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParceiroTipo.ToListAsync());
        }

        // GET: ParceiroTipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiroTipo = await _context.ParceiroTipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parceiroTipo == null)
            {
                return NotFound();
            }

            return View(parceiroTipo);
        }

        // GET: ParceiroTipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParceiroTipo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] ParceiroTipo parceiroTipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parceiroTipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parceiroTipo);
        }

        // GET: ParceiroTipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiroTipo = await _context.ParceiroTipo.FindAsync(id);
            if (parceiroTipo == null)
            {
                return NotFound();
            }
            return View(parceiroTipo);
        }

        // POST: ParceiroTipo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] ParceiroTipo parceiroTipo)
        {
            if (id != parceiroTipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parceiroTipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParceiroTipoExists(parceiroTipo.Id))
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
            return View(parceiroTipo);
        }

        // GET: ParceiroTipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiroTipo = await _context.ParceiroTipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parceiroTipo == null)
            {
                return NotFound();
            }

            return View(parceiroTipo);
        }

        // POST: ParceiroTipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parceiroTipo = await _context.ParceiroTipo.FindAsync(id);
            _context.ParceiroTipo.Remove(parceiroTipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParceiroTipoExists(int id)
        {
            return _context.ParceiroTipo.Any(e => e.Id == id);
        }
    }
}

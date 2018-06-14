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
    public class SegmentoController : Controller
    {
        private readonly SisCorContext _context;

        public SegmentoController(SisCorContext context)
        {
            _context = context;
        }

        // GET: Segmento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Segmento.ToListAsync());
        }

        // GET: Segmento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var segmento = await _context.Segmento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (segmento == null)
            {
                return NotFound();
            }

            return View(segmento);
        }

        // GET: Segmento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Segmento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] Segmento segmento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(segmento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(segmento);
        }

        // GET: Segmento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var segmento = await _context.Segmento.FindAsync(id);
            if (segmento == null)
            {
                return NotFound();
            }
            return View(segmento);
        }

        // POST: Segmento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] Segmento segmento)
        {
            if (id != segmento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(segmento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SegmentoExists(segmento.Id))
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
            return View(segmento);
        }

        // GET: Segmento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var segmento = await _context.Segmento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (segmento == null)
            {
                return NotFound();
            }

            return View(segmento);
        }

        // POST: Segmento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var segmento = await _context.Segmento.FindAsync(id);
            _context.Segmento.Remove(segmento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SegmentoExists(int id)
        {
            return _context.Segmento.Any(e => e.Id == id);
        }
    }
}

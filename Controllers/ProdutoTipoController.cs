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
    public class ProdutoTipoController : Controller
    {
        private readonly SisCorContext _context;

        public ProdutoTipoController(SisCorContext context)
        {
            _context = context;
        }

        // GET: ProdutoTipo
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoTipo.ToListAsync());
        }

        // GET: ProdutoTipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoTipo = await _context.ProdutoTipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoTipo == null)
            {
                return NotFound();
            }

            return View(produtoTipo);
        }

        // GET: ProdutoTipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutoTipo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] ProdutoTipo produtoTipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoTipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoTipo);
        }

        // GET: ProdutoTipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoTipo = await _context.ProdutoTipo.FindAsync(id);
            if (produtoTipo == null)
            {
                return NotFound();
            }
            return View(produtoTipo);
        }

        // POST: ProdutoTipo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] ProdutoTipo produtoTipo)
        {
            if (id != produtoTipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoTipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoTipoExists(produtoTipo.Id))
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
            return View(produtoTipo);
        }

        // GET: ProdutoTipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoTipo = await _context.ProdutoTipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoTipo == null)
            {
                return NotFound();
            }

            return View(produtoTipo);
        }

        // POST: ProdutoTipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoTipo = await _context.ProdutoTipo.FindAsync(id);
            _context.ProdutoTipo.Remove(produtoTipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoTipoExists(int id)
        {
            return _context.ProdutoTipo.Any(e => e.Id == id);
        }
    }
}

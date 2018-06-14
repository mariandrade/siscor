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
    public class TabelaController : Controller
    {
        private readonly SisCorContext _context;

        public TabelaController(SisCorContext context)
        {
            _context = context;
        }

        // GET: Tabela
        public async Task<IActionResult> Index()
        {
            var sisCorContext = _context.Tabela.Include(t => t.IdProdutoNavigation).Include(t => t.IdTabelaTipoNavigation);
            return View(await sisCorContext.ToListAsync());
        }

        // GET: Tabela/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabela = await _context.Tabela
                .Include(t => t.IdProdutoNavigation)
                .Include(t => t.IdTabelaTipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabela == null)
            {
                return NotFound();
            }

            return View(tabela);
        }

        // GET: Tabela/Create
        public IActionResult Create()
        {
            ViewData["IdProduto"] = new SelectList(_context.Produto, "Id", "Id");
            ViewData["IdTabelaTipo"] = new SelectList(_context.TabelaTipo, "Id", "Descricao");
            return View();
        }

        // POST: Tabela/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,IdProduto,IdTabelaTipo")] Tabela tabela)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProduto"] = new SelectList(_context.Produto, "Id", "Id", tabela.IdProduto);
            ViewData["IdTabelaTipo"] = new SelectList(_context.TabelaTipo, "Id", "Descricao", tabela.IdTabelaTipo);
            return View(tabela);
        }

        // GET: Tabela/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabela = await _context.Tabela.FindAsync(id);
            if (tabela == null)
            {
                return NotFound();
            }
            ViewData["IdProduto"] = new SelectList(_context.Produto, "Id", "Id", tabela.IdProduto);
            ViewData["IdTabelaTipo"] = new SelectList(_context.TabelaTipo, "Id", "Descricao", tabela.IdTabelaTipo);
            return View(tabela);
        }

        // POST: Tabela/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Descricao,IdProduto,IdTabelaTipo")] Tabela tabela)
        {
            if (id != tabela.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelaExists(tabela.Id))
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
            ViewData["IdProduto"] = new SelectList(_context.Produto, "Id", "Id", tabela.IdProduto);
            ViewData["IdTabelaTipo"] = new SelectList(_context.TabelaTipo, "Id", "Descricao", tabela.IdTabelaTipo);
            return View(tabela);
        }

        // GET: Tabela/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabela = await _context.Tabela
                .Include(t => t.IdProdutoNavigation)
                .Include(t => t.IdTabelaTipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabela == null)
            {
                return NotFound();
            }

            return View(tabela);
        }

        // POST: Tabela/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tabela = await _context.Tabela.FindAsync(id);
            _context.Tabela.Remove(tabela);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelaExists(string id)
        {
            return _context.Tabela.Any(e => e.Id == id);
        }
    }
}

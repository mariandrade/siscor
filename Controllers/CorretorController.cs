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
    public class CorretorController : Controller
    {
        private readonly SisCorContext _context;

        public CorretorController(SisCorContext context)
        {
            _context = context;
        }

        // GET: Corretor
        public async Task<IActionResult> Index()
        {
            var sisCorContext = _context.Parceiro.Include(p => p.IdParceiroTipoNavigation).Include(p => p.IdPessoaNavigation);
            return View(await sisCorContext.ToListAsync());
        }

        // GET: Corretor/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiro = await _context.Parceiro
                .Include(p => p.IdParceiroTipoNavigation)
                .Include(p => p.IdPessoaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parceiro == null)
            {
                return NotFound();
            }

            return View(parceiro);
        }

        // GET: Corretor/Create
        public IActionResult Create()
        {
            ViewData["IdParceiroTipo"] = new SelectList(_context.ParceiroTipo, "Id", "Descricao");
            ViewData["IdPessoa"] = new SelectList(_context.Pessoa, "Id", "Id");
            return View();
        }

        // POST: Corretor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,IdPessoa,IdParceiroTipo")] Parceiro parceiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parceiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdParceiroTipo"] = new SelectList(_context.ParceiroTipo, "Id", "Descricao", parceiro.IdParceiroTipo);
            ViewData["IdPessoa"] = new SelectList(_context.Pessoa, "Id", "Id", parceiro.IdPessoa);
            return View(parceiro);
        }

        // GET: Corretor/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiro = await _context.Parceiro.FindAsync(id);
            if (parceiro == null)
            {
                return NotFound();
            }
            ViewData["IdParceiroTipo"] = new SelectList(_context.ParceiroTipo, "Id", "Descricao", parceiro.IdParceiroTipo);
            ViewData["IdPessoa"] = new SelectList(_context.Pessoa, "Id", "Id", parceiro.IdPessoa);
            return View(parceiro);
        }

        // POST: Corretor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Descricao,IdPessoa,IdParceiroTipo")] Parceiro parceiro)
        {
            if (id != parceiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parceiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParceiroExists(parceiro.Id))
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
            ViewData["IdParceiroTipo"] = new SelectList(_context.ParceiroTipo, "Id", "Descricao", parceiro.IdParceiroTipo);
            ViewData["IdPessoa"] = new SelectList(_context.Pessoa, "Id", "Id", parceiro.IdPessoa);
            return View(parceiro);
        }

        // GET: Corretor/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiro = await _context.Parceiro
                .Include(p => p.IdParceiroTipoNavigation)
                .Include(p => p.IdPessoaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parceiro == null)
            {
                return NotFound();
            }

            return View(parceiro);
        }

        // POST: Corretor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var parceiro = await _context.Parceiro.FindAsync(id);
            _context.Parceiro.Remove(parceiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParceiroExists(string id)
        {
            return _context.Parceiro.Any(e => e.Id == id);
        }
    }
}

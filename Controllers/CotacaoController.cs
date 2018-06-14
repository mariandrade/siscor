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
    public class CotacaoController : Controller
    {
        private readonly SisCorContext _context;

        public CotacaoController(SisCorContext context)
        {
            _context = context;
        }

        // GET: Cotacao
        public async Task<IActionResult> Index()
        {
            var sisCorContext = _context.Cotacao.Include(c => c.IdClienteNavigation);
            return View(await sisCorContext.ToListAsync());
        }

        // GET: Cotacao/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacao = await _context.Cotacao
                .Include(c => c.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cotacao == null)
            {
                return NotFound();
            }

            return View(cotacao);
        }

        // GET: Cotacao/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id");
            return View();
        }

        // POST: Cotacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,Uri,Ativo,DataCriacao,CriadoPor")] Cotacao cotacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cotacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id", cotacao.IdCliente);
            return View(cotacao);
        }

        // GET: Cotacao/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacao = await _context.Cotacao.FindAsync(id);
            if (cotacao == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id", cotacao.IdCliente);
            return View(cotacao);
        }

        // POST: Cotacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,IdCliente,Uri,Ativo,DataCriacao,CriadoPor")] Cotacao cotacao)
        {
            if (id != cotacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cotacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CotacaoExists(cotacao.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id", cotacao.IdCliente);
            return View(cotacao);
        }

        // GET: Cotacao/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacao = await _context.Cotacao
                .Include(c => c.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cotacao == null)
            {
                return NotFound();
            }

            return View(cotacao);
        }

        // POST: Cotacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cotacao = await _context.Cotacao.FindAsync(id);
            _context.Cotacao.Remove(cotacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CotacaoExists(string id)
        {
            return _context.Cotacao.Any(e => e.Id == id);
        }
    }
}

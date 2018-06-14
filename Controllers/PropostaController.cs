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
    public class PropostaController : Controller
    {
        private readonly SisCorContext _context;

        public PropostaController(SisCorContext context)
        {
            _context = context;
        }

        // GET: Proposta
        public async Task<IActionResult> Index()
        {
            var sisCorContext = _context.Proposta.Include(p => p.IdClienteNavigation);
            return View(await sisCorContext.ToListAsync());
        }

        // GET: Proposta/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta
                .Include(p => p.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
            {
                return NotFound();
            }

            return View(proposta);
        }

        // GET: Proposta/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id");
            return View();
        }

        // POST: Proposta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,IdParceiro,IdCotacao,DataCriacao,CriadoPor,DataEdicao,EditadoPor")] Proposta proposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proposta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id", proposta.IdCliente);
            return View(proposta);
        }

        // GET: Proposta/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta.FindAsync(id);
            if (proposta == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id", proposta.IdCliente);
            return View(proposta);
        }

        // POST: Proposta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,IdCliente,IdParceiro,IdCotacao,DataCriacao,CriadoPor,DataEdicao,EditadoPor")] Proposta proposta)
        {
            if (id != proposta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropostaExists(proposta.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Id", proposta.IdCliente);
            return View(proposta);
        }

        // GET: Proposta/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta
                .Include(p => p.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
            {
                return NotFound();
            }

            return View(proposta);
        }

        // POST: Proposta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var proposta = await _context.Proposta.FindAsync(id);
            _context.Proposta.Remove(proposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropostaExists(string id)
        {
            return _context.Proposta.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using APINETCOREProjExercicio.Data;
using APINETCOREProjExercicio.Model;

namespace APINETCOREProjExercicio.Controllers
{
    public class PadariasController : Controller
    {
        private readonly APINETCOREProjExercicioContext _context;

        public PadariasController(APINETCOREProjExercicioContext context)
        {
            _context = context;
        }

        // GET: Padarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Padaria.ToListAsync());
        }

        // GET: Padarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padaria = await _context.Padaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (padaria == null)
            {
                return NotFound();
            }

            return View(padaria);
        }

        // GET: Padarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Padarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CNPJ,QtdFuncionarios,Endereco,Telephone")] Padaria padaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(padaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(padaria);
        }

        // GET: Padarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padaria = await _context.Padaria.FindAsync(id);
            if (padaria == null)
            {
                return NotFound();
            }
            return View(padaria);
        }

        // POST: Padarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CNPJ,QtdFuncionarios,Endereco,Telephone")] Padaria padaria)
        {
            if (id != padaria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(padaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PadariaExists(padaria.Id))
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
            return View(padaria);
        }

        // GET: Padarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padaria = await _context.Padaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (padaria == null)
            {
                return NotFound();
            }

            return View(padaria);
        }

        // POST: Padarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var padaria = await _context.Padaria.FindAsync(id);
            _context.Padaria.Remove(padaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PadariaExists(int id)
        {
            return _context.Padaria.Any(e => e.Id == id);
        }
    }
}

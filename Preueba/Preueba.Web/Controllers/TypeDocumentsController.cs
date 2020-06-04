using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Preueba.Web.Data.Entities;
using Prueba.Web.Models;

namespace Prueba.Web.Controllers
{
    public class TypeDocumentsController : Controller
    {
        private readonly DataContext _context;

        public TypeDocumentsController(DataContext context)
        {
            _context = context;
        }

        // GET: TypeDocuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeDocument.ToListAsync());
        }

        // GET: TypeDocuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeDocument = await _context.TypeDocument
                .FirstOrDefaultAsync(m => m.IdDocumet == id);
            if (typeDocument == null)
            {
                return NotFound();
            }

            return View(typeDocument);
        }

        // GET: TypeDocuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeDocuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDocumet,TypeDocum")] TypeDocument typeDocument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeDocument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeDocument);
        }

        // GET: TypeDocuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeDocument = await _context.TypeDocument.FindAsync(id);
            if (typeDocument == null)
            {
                return NotFound();
            }
            return View(typeDocument);
        }

        // POST: TypeDocuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDocumet,TypeDocum")] TypeDocument typeDocument)
        {
            if (id != typeDocument.IdDocumet)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeDocument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeDocumentExists(typeDocument.IdDocumet))
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
            return View(typeDocument);
        }

        // GET: TypeDocuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeDocument = await _context.TypeDocument
                .FirstOrDefaultAsync(m => m.IdDocumet == id);
            if (typeDocument == null)
            {
                return NotFound();
            }

            return View(typeDocument);
        }

        // POST: TypeDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeDocument = await _context.TypeDocument.FindAsync(id);
            _context.TypeDocument.Remove(typeDocument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeDocumentExists(int id)
        {
            return _context.TypeDocument.Any(e => e.IdDocumet == id);
        }
    }
}

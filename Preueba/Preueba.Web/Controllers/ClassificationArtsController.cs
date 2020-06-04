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
    public class ClassificationArtsController : Controller
    {
        private readonly DataContext _context;

        public ClassificationArtsController(DataContext context)
        {
            _context = context;
        }

        // GET: ClassificationArts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClassificationArt.ToListAsync());
        }

        // GET: ClassificationArts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classificationArt = await _context.ClassificationArt
                .FirstOrDefaultAsync(m => m.ArtcId == id);
            if (classificationArt == null)
            {
                return NotFound();
            }

            return View(classificationArt);
        }

        // GET: ClassificationArts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassificationArts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtcId,NameArtc")] ClassificationArt classificationArt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classificationArt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classificationArt);
        }

        // GET: ClassificationArts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classificationArt = await _context.ClassificationArt.FindAsync(id);
            if (classificationArt == null)
            {
                return NotFound();
            }
            return View(classificationArt);
        }

        // POST: ClassificationArts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtcId,NameArtc")] ClassificationArt classificationArt)
        {
            if (id != classificationArt.ArtcId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classificationArt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassificationArtExists(classificationArt.ArtcId))
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
            return View(classificationArt);
        }

        // GET: ClassificationArts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classificationArt = await _context.ClassificationArt
                .FirstOrDefaultAsync(m => m.ArtcId == id);
            if (classificationArt == null)
            {
                return NotFound();
            }

            return View(classificationArt);
        }

        // POST: ClassificationArts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classificationArt = await _context.ClassificationArt.FindAsync(id);
            _context.ClassificationArt.Remove(classificationArt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassificationArtExists(int id)
        {
            return _context.ClassificationArt.Any(e => e.ArtcId == id);
        }
    }
}

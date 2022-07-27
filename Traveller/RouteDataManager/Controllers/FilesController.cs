using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;

namespace RouteDataManager.Controllers
{
    public class FilesController : Controller
    {
        private readonly ApplicationContext _context;

        public FilesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Files
        public async Task<IActionResult> Index()
        {
              return _context.Files != null ? 
                          View(await _context.Files.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Files'  is null.");
        }

        // GET: Files/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Files == null)
            {
                return NotFound();
            }

            var files = await _context.Files
                .FirstOrDefaultAsync(m => m.DocumentId == id);
            if (files == null)
            {
                return NotFound();
            }

            return View(files);
        }

        // GET: Files/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: Files/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("DocumentId,Name,FileType,DataFiles,CreatedOn")] Files files)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(files);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(files);
        //}

        [HttpPost]
        public IActionResult Create(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var fileExtension = Path.GetExtension(fileName);                

                    var objfiles = new Files()
                    {
                        DocumentId = 0,
                        Name = fileName,
                        FileType = fileExtension,
                        CreatedOn = DateTime.Now
                    };

                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objfiles.DataFiles = target.ToArray();
                    }

                    _context.Files.Add(objfiles);
                    _context.SaveChanges();

                }
            }
            return View();
        }

        // GET: Files/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Files == null)
            {
                return NotFound();
            }

            var files = await _context.Files.FindAsync(id);
            if (files == null)
            {
                return NotFound();
            }
            return View(files);
        }

        // POST: Files/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DocumentId,Name,FileType,DataFiles,CreatedOn")] Files files)
        {
            if (id != files.DocumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(files);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilesExists(files.DocumentId))
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
            return View(files);
        }

        // GET: Files/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Files == null)
            {
                return NotFound();
            }

            var files = await _context.Files
                .FirstOrDefaultAsync(m => m.DocumentId == id);
            if (files == null)
            {
                return NotFound();
            }

            return View(files);
        }

        // POST: Files/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Files == null)
            {
                return Problem("Entity set 'ApplicationContext.Files'  is null.");
            }
            var files = await _context.Files.FindAsync(id);
            if (files != null)
            {
                _context.Files.Remove(files);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilesExists(int id)
        {
          return (_context.Files?.Any(e => e.DocumentId == id)).GetValueOrDefault();
        }
    }
}

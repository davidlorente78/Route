using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Models;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels.RailwaySystem;
using Traveller.Domain;

namespace CURDOperationWithImageUploadCore5_Demo.Controllers
{
    public class RailwaySystemsController : Controller
    {        
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _environment;
        public RailwaySystemsController(ApplicationContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.RailwaySystems.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var railwaySystem = await _context.RailwaySystems
                    .FirstOrDefaultAsync(m => m.Id == id);

                var railwaySystemViewModel = new RailwaySystemViewModel()
                {
                    Id = railwaySystem.Id,
                    Name = railwaySystem.Name,                  
                    Description = railwaySystem.Description,
                    ExistingImage = railwaySystem.MapPicture
                };

                if (railwaySystem == null)
                {
                    return NotFound();
                }
                return View(railwaySystem);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RailwaySystemViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uniqueFileName = ProcessUploadedFile(model);
                    RailwaySystem  railwaySystem = new()
                    {
                         Name = model.Name,
                         Description = model.Description,                                
                         MapPicture = uniqueFileName
                    };

                    _context.Add(railwaySystem);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var railwaySystem= await _context.RailwaySystems.FindAsync(id);
            var railwaySystemViewModel = new RailwaySystemViewModel()
            {
                Id = railwaySystem.Id,
                Name = railwaySystem.Name,               
                Description = railwaySystem.Description,
                ExistingImage = railwaySystem.MapPicture
            };

            if (railwaySystem == null)
            {
                return NotFound();
            }
            return View(railwaySystemViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RailwaySystemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var railwaySystem = await _context.RailwaySystems.FindAsync(model.Id);

                railwaySystem.Name = model.Name;
                railwaySystem.Description = model.Description;
           

                if (model.MapPicture != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_environment.WebRootPath, RailwaySystemFileLocation.FileUploadFolder, model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    railwaySystem.MapPicture = ProcessUploadedFile(model);
                }
                _context.Update(railwaySystem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var railwaySystem = await _context.RailwaySystems
                .FirstOrDefaultAsync(m => m.Id == id);

            var railwaySystemViewModel = new RailwaySystemViewModel()
            {
                Id = railwaySystem.Id,
                Name = railwaySystem.Name,           
                Description = railwaySystem.Description,
                ExistingImage = railwaySystem.MapPicture
            };
            if (railwaySystem == null)
            {
                return NotFound();
            }

            return View(railwaySystemViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var railwaySystem = await _context.RailwaySystems.FindAsync(id);
            //string deleteFileFromFolder = "wwwroot\\Uploads\\";
            string deleteFileFromFolder=Path.Combine(_environment.WebRootPath, RailwaySystemFileLocation.FileUploadFolder, @"\");
            var CurrentImage = Path.Combine(Directory.GetCurrentDirectory(), deleteFileFromFolder, railwaySystem.MapPicture);
            _context.RailwaySystems.Remove(railwaySystem);
            if (System.IO.File.Exists(CurrentImage))
            {
                System.IO.File.Delete(CurrentImage);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RailwaySystemsExists(int id)
        {
            return _context.RailwaySystems.Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(RailwaySystemViewModel model)
        {
            string uniqueFileName = null;
            string path = Path.Combine(_environment.WebRootPath, RailwaySystemFileLocation.FileUploadFolder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (model.MapPicture != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, RailwaySystemFileLocation.FileUploadFolder);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.MapPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.MapPicture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}

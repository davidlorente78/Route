using Domain.Transport.Aviation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Models;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels.Airline;

namespace CURDOperationWithImageUploadCore5_Demo.Controllers
{
    public class AirlinesController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _environment;
        public AirlinesController(ApplicationContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Airlines.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var airline = await _context.Airlines
                    .FirstOrDefaultAsync(m => m.Id == id);

                var airlineViewModel = new AirlineViewModel()
                {
                    Id = airline.Id,
                    Name = airline.Name,
                    //TODO
                    Description = airline.Description,
                    ExistingImage = airline.Picture
                };

                if (airline == null)
                {
                    return NotFound();
                }
                //TO CHECK AQUI NO DEVUELVE EL VIEW MODEL
                return View(airline);
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
        public async Task<IActionResult> Create(AirlineViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uniqueFileName = ProcessUploadedFile(model);
                    Airline airline = new()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Picture = uniqueFileName
                    };

                    _context.Add(airline);
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

            var airline = await _context.Airlines.FindAsync(id);
            var airlineViewModel = new AirlineViewModel()
            {
                Id = airline.Id,
                Name = airline.Name,
                Description = airline.Description,
                ExistingImage = airline.Picture
                //TODO OTHER FIELDS
            };


            //Esto antes del <view model acces
            if (airline == null)
            {
                return NotFound();
            }
            return View(airlineViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AirlineViewModel model)
        {
            try
            {
                var airline = await _context.Airlines.FindAsync(model.Id);

                airline.Name = model.Name;
                airline.Description = model.Description;

                if (model.MapPicture != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_environment.WebRootPath, AirlineFileLocation.FileUploadFolder, model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    //Here is the name of the file with the Guid Unique File Name
                    airline.Picture = ProcessUploadedFile(model);
                }
                _context.Update(airline);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch { throw; }

            return PartialView(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airline = await _context.Airlines
                .FirstOrDefaultAsync(m => m.Id == id);

            var airlineViewModel = new AirlineViewModel()
            {
                Id = airline.Id,
                Name = airline.Name,
                Description = airline.Description,
                ExistingImage = airline.Picture
            };
            if (airline == null)
            {
                return NotFound();
            }

            return View(airlineViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airline = await _context.Airlines.FindAsync(id);
            _context.Airlines.Remove(airline);

            string deleteCurrentImageFilePath = _environment.WebRootPath + @"\" + AirlineFileLocation.FileUploadFolder + airline.Picture;

            if (System.IO.File.Exists(deleteCurrentImageFilePath))
            {
                System.IO.File.Delete(deleteCurrentImageFilePath);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirlineExists(int id)
        {
            return _context.Airlines.Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(AirlineViewModel model)
        {
            string uniqueFileName = null;
            string path = Path.Combine(_environment.WebRootPath, AirlineFileLocation.FileUploadFolder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (model.MapPicture != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, AirlineFileLocation.FileUploadFolder);
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

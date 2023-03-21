using Application.Dto.Generic;
using Domain.Generic;
using DomainServices.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RouteDataManager.Controllers.Generic
{
    public class GenericController<TDto, TEntity> : Controller
        where TDto : GenericDto
        where TEntity : Entity

    {
        public readonly IGenericService<TDto, TEntity> genericService;

        public GenericController(IGenericService<TDto, TEntity> genericService)
        {
            this.genericService = genericService;
        }

        public virtual IActionResult Index(int? id)
        {
            //var countryIndexViewModel = new CountryIndexViewModel();

            ICollection<TDto>? dtos = genericService.GetAll();

            //countryIndexViewModel.Countries = dtos;

            //if (id != null)
            //{
            //    ViewBag.CountryId = id.Value;
            //}

            return View(dtos);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDto dto = genericService.GetByID((int)id);

            if (dto == null)
            {
                return NotFound();
            }

            return View(dto);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name")] TDto dto)
        {
            if (ModelState.IsValid)
            {
                genericService.Add(dto);

                return RedirectToAction(nameof(Index));
            }

            return PartialView(dto);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || genericService.Exists(id.Value) == false)
            {
                return NotFound();
            }

            TDto dto = genericService.GetByID(id.Value);

            if (dto == null)
            {
                return NotFound();
            }
            return PartialView(dto);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name")] TDto dto)
        {
            if (id != dto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    genericService.Update(dto);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!genericService.Exists(dto.Id))
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
            return View(dto);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || !genericService.Exists(id.Value))
            {
                return NotFound();
            }

            TDto dto = genericService.GetByID(id.Value);

            if (dto == null)
            {
                return NotFound();
            }

            return View(dto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            TDto dto = genericService.GetByID(id);

            if (dto != null)
            {
                genericService.Remove(dto.Id);
            }
            else
            {
                return Problem("Country does not exist.");
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

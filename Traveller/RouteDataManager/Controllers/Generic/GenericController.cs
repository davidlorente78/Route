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
            ICollection<TDto>? dtos = genericService.GetAll();

            return View(dtos);
        }

        public virtual IActionResult Details(int? id)
        {
            if (id == null)
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


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Create(TDto dto)
        {
            if (ModelState.IsValid)
            {
                genericService.Add(dto);

                return RedirectToAction(nameof(Index));
            }

            return PartialView(dto);
        }

        public virtual IActionResult Edit(int? id)
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
        public virtual IActionResult Edit(int id, TDto dto)
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

        public virtual IActionResult Delete(int? id)
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
        public IActionResult DeleteConfirmed(int id)
        {
            TDto dto = genericService.GetByID(id);

            if (dto != null)
            {
                genericService.Remove(dto.Id);
            }
            else
            {
                return Problem("Entity does not exist.");
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

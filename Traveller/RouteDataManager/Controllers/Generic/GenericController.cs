using Application.Dto.Generic;
using Domain.Generic;
using Domain.Messages;
using DomainServices.Generic;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RouteDataManager.Controllers.Generic
{
    public class GenericController<TDto, TEntity> : Controller
        where TDto : GenericDto
        where TEntity : Entity

    {
        public readonly IGenericService<TDto, TEntity> genericService;

        private readonly IPublishEndpoint publishEndpoint;

        public GenericController(
            IGenericService<TDto, TEntity> genericService,
            IPublishEndpoint publishEndpoint)
        {
            this.genericService = genericService;

            //Allows us to submit a message to the RabbitMQ Exchange 
            this.publishEndpoint = publishEndpoint;
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

        public virtual IActionResult Create()
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

                var entityCreated =

                    publishEndpoint.Publish<EntityCreated>
                        (new()
                        {
                            Type = typeof(TEntity).Name,
                            Message = "Created new " + typeof(TEntity).Name,
                            CreatedDate = DateTime.UtcNow,
                        });

                //Para verificar los mensajes publicados en la cola, puedes utilizar la consola de administración de RabbitMQ.
                //Si accedes a http://localhost:15672/ (o el puerto que hayas configurado), podrás ver las colas y los mensajes en ellas.
                //En este caso, deberías buscar la cola "CreatedEntitiesQueue" y verificar si los mensajes se encuentran allí.

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

                    var entityUpdated =

                  publishEndpoint.Publish<EntityUpdated>
                      (new()
                      {
                          Id = dto.Id,
                          Type = typeof(TEntity).Name,
                          Message = "Updated Entity " + typeof(TEntity).Name,
                          CreatedDate = DateTime.UtcNow,
                      });

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

                var entityCreated =

                    publishEndpoint.Publish<EntityDeleted>
                        (new()
                        {
                            Id = dto.Id,
                            Type = typeof(TEntity).Name,
                            Message = "Deleted Entity " + typeof(TEntity).Name,
                            CreatedDate = DateTime.UtcNow,
                        });
            }
            else
            {
                return Problem("Entity does not exist.");
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

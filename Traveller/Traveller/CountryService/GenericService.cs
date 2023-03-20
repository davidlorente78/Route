using AutoMapper;
using Domain.Generic;
using Domain.Repositories;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;

namespace Traveller.DomainServices
{
    public class GenericService<TDto, TEntity>
        where TDto : Dto
        where TEntity : Entity
    {
        protected IUnitOfWork unitOfWork;
        protected readonly IMapper mapper;
        private IGenericRepository<TEntity> repository;

        public GenericService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<TEntity> repository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.repository = repository;
        }

        public bool Exists(int id)
        {
            return (repository?.Find(e => e.Id == id)).Count() != 0;
        }

        public ICollection<TDto> GetAll()
        {
            var entities = repository.GetAll().ToList();

            List<TDto> dtos = mapper.Map<List<TDto>>(entities);

            return dtos;
        }

        public TDto GetByID(int id)
        {
            var entity = repository.GetById(id);
            TDto dto = mapper.Map<TDto>(entity);

            return dto;
        }

        public int Add(TDto dto)
        {
            var entity = CreateEntityFromDto(dto);
            repository.Add(entity);

            return unitOfWork.SaveChanges();
        }

        public int Remove(int id)
        {
            var entity = GetEntityByID(id);
            repository.Remove(entity);
            return unitOfWork.SaveChanges();
        }

        public int Update(TDto dto)
        {
            var entity = GetEntityByID(dto.Id);

            entity = UpdateEntityFromDto(dto, entity);
            repository.Update(entity);

            return unitOfWork.SaveChanges();
        }

        private TEntity GetEntityByID(int id)
        {
            var entity = repository.GetById(id);

            return entity;
        }

        //Esto sacarlo a un mapper. TODO
        private TEntity CreateEntityFromDto(TDto dto)
        {
            TEntity entity = mapper.Map<TEntity>(dto);
            return entity;
        }

        private TEntity UpdateEntityFromDto(TDto dto, TEntity entity)
        {
            entity.Id = dto.Id;
            return entity;
        }

    }
}

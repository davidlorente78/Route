using Application.Dto.Generic;
using Application.Mapper;
using Domain.Generic;
using Domain.Repositories;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DomainServices.GenericService
{
    public class GenericService<TDto, TEntity>
        where TDto : GenericDto
        where TEntity : Entity
    {
        protected IUnitOfWork unitOfWork;
        protected readonly GenericMapper<TDto, TEntity> genericMapper;
        private IGenericRepository<TEntity> repository;

        public GenericService(IUnitOfWork unitOfWork, GenericMapper<TDto, TEntity> genericMapper, IGenericRepository<TEntity> repository)
        {
            this.unitOfWork = unitOfWork;
            this.genericMapper = genericMapper;
            this.repository = repository;
        }

        public bool Exists(int id)
        {
            return (repository?.Find(e => e.Id == id)).Count() != 0;
        }

        public ICollection<TDto> GetAll()
        {
            var entities = repository.GetAll().ToList();

            List<TDto> dtos = genericMapper.mapper.Map<List<TDto>>(entities);

            return dtos;
        }

        public TDto GetByID(int id)
        {
            var entity = repository.GetById(id);
            TDto dto = genericMapper.mapper.Map<TDto>(entity);

            return dto;
        }

        public int Add(TDto dto)
        {
            var entity = genericMapper.CreateEntityFromDto(dto);
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

            entity = genericMapper.UpdateEntityFromDto(dto, entity);
            repository.Update(entity);

            return unitOfWork.SaveChanges();
        }

        private TEntity GetEntityByID(int id)
        {
            var entity = repository.GetById(id);

            return entity;
        }
    }
}

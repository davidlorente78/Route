using Application.Dto.Generic;
using Application.Mapper.Generic;
using AutoMapper;
using Domain.Generic;
using Domain.Repositories;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DomainServices.Generic
{
    public class GenericService<TDto, TEntity> : IGenericService<TDto, TEntity>
        where TDto : GenericDto
        where TEntity : Entity 
      
    {
        protected IUnitOfWork unitOfWork;
        protected readonly IGenericMapper<TDto, TEntity> genericMapper;
        private IGenericRepository<TEntity> repository;
        public readonly IMapper mapper;

        public GenericService(IUnitOfWork unitOfWork, IGenericMapper<TDto, TEntity> genericMapper, IMapper mapper, IGenericRepository<TEntity> repository)
        {
            this.unitOfWork = unitOfWork;
            this.genericMapper = genericMapper;
            this.repository = repository;
            this.mapper = mapper;
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

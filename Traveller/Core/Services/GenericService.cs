﻿using Application.Dto.Generic;
using Application.Mapper.Generic;
using AutoMapper;
using Core.Application.Dto;
using Core.Domain;
using Domain.Repositories;
using RouteDataManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DomainServices.Generic
{
    public class GenericService<TDto, TEntity> : IGenericService<TDto, TEntity>
        where TDto : GenericDto
        where TEntity : Entity

    {
        ////Da acceso a todos los repositorios y es posible implementar metodos con Order o Include
        protected IUnitOfWork unitOfWork;

        //Utiliza Automapper y el Profile basico definido para realizar la transformacion
        public readonly IMapper mapper;

        protected readonly IGenericMapper<TDto, TEntity> genericMapper;
        private IGenericRepository<TEntity> repository;

        public GenericService(IUnitOfWork unitOfWork, IMapper mapper, IGenericMapper<TDto, TEntity> genericMapper, IGenericRepository<TEntity> repository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

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

            List<TDto> dtos = mapper.Map<List<TDto>>(entities);

            return dtos;
        }

        public TDto GetById(int id)
        {
            var entity = repository.GetById(id);
            TDto dto = mapper.Map<TDto>(entity);

            return dto;
        }

        //https://stackoverflow.com/questions/5376421/ef-including-other-entities-generic-repository-pattern
        public ICollection<TDto> GetIncluding(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        {
            var entities = repository.Including(expression, includes);

            List<TDto> dtos = mapper.Map<List<TDto>>(entities);

            return dtos;
        }

        public int Add(TDto dto)
        {
            var entity = genericMapper.CreateEntityFromDto(dto);
            repository.Add(entity);
            unitOfWork.SaveChanges();
            return entity.Id;
        }

        public int Remove(int id)
        {
            var entity = GetEntityById(id);

            repository.Remove(entity);

            return unitOfWork.SaveChanges();
        }

        public int Update(TDto dto)
        {
            var entity = GetEntityById(dto.Id);

            entity = genericMapper.UpdateEntityFromDto(dto, entity);

            repository.Update(entity);

            return unitOfWork.SaveChanges();
        }

        private TEntity GetEntityById(int id)
        {
            var entity = repository.GetById(id);

            return entity;
        }
    }
}

using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class RailwayBranchMapper : GenericMapper<RailwayBranchDto, RailwayBranch>, IRailwayBranchMapper
    {
        public RailwayBranchMapper(IMapper mapper) : base(mapper) { }

        public override RailwayBranch CreateEntityFromDto(RailwayBranchDto dto)
        {
            ValidateDto(dto);

            RailwayBranch entity = mapper.Map<RailwayBranch>(dto);
            entity.Name = dto.Name;
            entity.Description = dto.Description;


            return entity;
        }

        public override RailwayBranch UpdateEntityFromDto(RailwayBranchDto dto, RailwayBranch entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Description = dto.Description;


            return entity;
        }

        private void ValidateDto(RailwayBranchDto dto)
        {
        }
    }
}

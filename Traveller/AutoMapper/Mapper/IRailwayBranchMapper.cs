﻿using Application.Mapper.Generic;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public interface IRailwayBranchMapper : IGenericMapper<RailwayBranchDto, RailwayBranch>
    {
    }
}
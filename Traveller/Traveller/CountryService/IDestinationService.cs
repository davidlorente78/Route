﻿using Traveller.Application.Dto;
using System.Collections.Generic;

namespace Traveller.DomainServices
{
    public interface IDestinationService
    {
        ICollection<DestinationDto> GetAllDestinations();
        //DestinationDto GetDestinationByID(int ID);
        //bool DestinationExists(int id);
        //int AddDestination(Destination destination);
        //int RemoveDestination(DestinationDto destinationDto);
        //int UpdateDestination(Destination destination);
    }
}
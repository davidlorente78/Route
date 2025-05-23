﻿using Domain.Repositories;
using Traveller.Domain;
using Microsoft.EntityFrameworkCore;

namespace RouteDataManager.Repositories
{
    public class BorderCrossingRepository : GenericRepository<BorderCrossing>, IBorderCrossingRepository
    {
        public BorderCrossingRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<BorderCrossing> GetBorderCrossingsByOriginCountryCode(int OriginCountryID)
        {
            return _context.BorderCrossings
                .Where(f => f.DestinationOrigin.Country.Id == OriginCountryID)
                .Include(f => f.DestinationFinal)
                .Include(f => f.DestinationOrigin)
                .OrderBy(c => c.Name)
                .ToList();
        }

        public IEnumerable<BorderCrossing> GetBorderCrossingsByFinalCountryCode(int FinalCountryID)
        {
            return _context.BorderCrossings
                .Where(f => f.DestinationFinal.Country.Id == FinalCountryID)
                .Include(f => f.DestinationFinal)
                .Include(f => f.DestinationOrigin)
                .OrderBy(c => c.Name)
                .ToList();
        }

        public IEnumerable<BorderCrossing> GetBorderCrossingsByOriginAndFinalCountryCode(int OriginCountryID, int FinalCountryID)
        {
            return _context.BorderCrossings
                .Where(f => f.DestinationFinal.Country.Id == FinalCountryID && f.DestinationOrigin.Country.Id == OriginCountryID)
                .Include(f => f.DestinationFinal)
                .Include(f => f.DestinationOrigin)
                .OrderBy(c => c.Name)
                .ToList();
        }
    }
}

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
                .Where(f => f.Origin.Country.CountryID == OriginCountryID)
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .OrderBy(c => c.Name)
                .ToList();
        }

        public IEnumerable<BorderCrossing> GetBorderCrossingsByFinalCountryCode(int FinalCountryID)
        {
            return _context.BorderCrossings
                .Where(f => f.Final.Country.CountryID == FinalCountryID)
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .OrderBy(c => c.Name)
                .ToList();
        }

        public IEnumerable<BorderCrossing> GetBorderCrossingsByOriginAndFinalCountryCode(int OriginCountryID, int FinalCountryID)
        {
            return _context.BorderCrossings
                .Where(f => f.Final.Country.CountryID == FinalCountryID && f.Origin.Country.CountryID == OriginCountryID)
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .OrderBy(c => c.Name)
                .ToList();
        }
    }
}
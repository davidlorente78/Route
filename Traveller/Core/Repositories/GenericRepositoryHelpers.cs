﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Repositories
{
    public static class GenericRepositoryHelpers
    {
        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes)
        where T : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }
    }
}
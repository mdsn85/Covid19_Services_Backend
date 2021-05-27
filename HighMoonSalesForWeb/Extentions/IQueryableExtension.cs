using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Extentions
{
    public static class IQueryableExtension
    {

        public static IQueryable<T> applyOrdering<T>(this IQueryable<T> query, IQueryObject filter ,  Dictionary<string, Expression<Func<T, object>>> columnMap)
        {

            if (String.IsNullOrWhiteSpace(filter.SortBy) || !columnMap.ContainsKey(filter.SortBy))
                return query;
            if (filter.IsSortAsc)
               return query = query.OrderBy(columnMap[filter.SortBy]);
            else
               return query = query.OrderByDescending(columnMap[filter.SortBy]);

     
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, IQueryObject queryObject)
        {
            if (queryObject.Page <= 0)
                queryObject.Page = 1;

            if (queryObject.PageSize <= 0)
                 queryObject.PageSize = 10;

            query = query.Skip((queryObject.Page - 1) * queryObject.PageSize).Take(queryObject.PageSize);
            return query;
        }
    }
}

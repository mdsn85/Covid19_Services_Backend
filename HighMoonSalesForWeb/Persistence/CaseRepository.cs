using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;
using Covid19_Services_Backend.Context;
using Covid19_Services_Backend.Controllers.Resources;
using Covid19_Services_Backend.Extentions;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;
using Covid19_Services_Backend.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Persistence
{
    public class CaseRepository : ICaseRepository
    {

        private readonly ApplicationContext DbContext;

        public CaseRepository(ApplicationContext context)
        {
            this.DbContext = context;
        }



        public async Task<QueryResult<Case>> GetAll(FilterCase filter)
        {
            var result = new QueryResult<Case>();
            var Cases =  DbContext.Cases
                .Include(l => l.Status)
                .Include(l => l.Country)
                .AsQueryable();


            if (filter.CountryId.HasValue)
            {
                Cases = Cases.Where(v => v.CountryId == filter.CountryId.Value);
            }
            if (!string.IsNullOrEmpty( filter.Date.ToString()))
            {
                DateTime nextDay = filter.Date.Value.AddDays(1);
                Cases = Cases.Where(v => v.Date>= filter.Date && v.Date< nextDay);
            }

            var columnMap = new Dictionary<string, Expression<Func<Case, object>>>()
            {
              
                ["CountryId"] = v => v.CountryId,
                ["Date"] = v => v.Date,
                ["Status"] = v => v.Status      
        
             };
            Cases = Cases.OrderByDescending(c => c.CaseId);

            Cases = Cases.applyOrdering(filter, columnMap);

            result.TotalItems = await Cases.CountAsync();

            Cases = Cases.ApplyPaging(filter);

            result.Items = await Cases.ToListAsync();
            return result;

        }



        public async Task<Case> Get(int id)
        {
            var result= await DbContext.Cases
                .Include(l => l.Status)
                .Include(l => l.Country)
                .Where(l => l.CaseId == id).FirstOrDefaultAsync();

            return result;
        }


        public async Task<Case> Add(Case Case)
        {
            await DbContext.Cases.AddAsync(Case);
            return Case;

        }

        public async Task<bool> Delete(int id)
        {
            var Case = DbContext.Cases.Find(id);
            
            DbContext.Cases.Remove(Case);
            await DbContext.SaveChangesAsync();
            return true;
        }


        public Case Update(Case Case)
        {
            DbContext.Entry(Case).State = EntityState.Modified;
            return Case;
        }

        public async Task<QueryResult<Case>> GetSummaryCasesByDay(FilterCase filter)
        {
            var result = new QueryResult<Case>();
            var Cases = DbContext.Cases
                .Include(l => l.Status)
                .Include(l => l.Country)
                .AsQueryable();


            if (filter.CountryId.HasValue)
            {
                Cases = Cases.Where(v => v.CountryId == filter.CountryId.Value);
            }
            if (!string.IsNullOrEmpty(filter.Date.ToString()))
            {
                Cases = Cases.Where(v => v.Date == filter.Date);
            }

            var columnMap = new Dictionary<string, Expression<Func<Case, object>>>()
            {

                ["CountryId"] = v => v.CountryId,
                ["Date"] = v => v.Date,
                ["Status"] = v => v.Status

            };

            Cases = Cases.applyOrdering(filter, columnMap);

            result.TotalItems = await Cases.CountAsync();

            Cases = Cases.ApplyPaging(filter);

            result.Items = await Cases.ToListAsync();
            return result;
        }
    }
}

using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Context;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Persistence
{
    public class MasterDataRepository : IMasterDataRepository
    {
        private readonly ApplicationContext db;

        public MasterDataRepository(ApplicationContext db)
        {
            this.db= db;
        }


        public async Task<IEnumerable<Country>> GetCountry()
        {
            return await db.Countries.ToListAsync();
        }

        public async Task<IEnumerable<StatusOfCase>> GetStatus()
        {
            return await db.Statuses.ToListAsync();
        }
    }
}

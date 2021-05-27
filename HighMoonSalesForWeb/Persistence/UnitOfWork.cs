using Covid19_Services_Backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext db;
        public UnitOfWork(ApplicationContext db)
        {
            this.db = db;
        }
        public async Task SaveChanges()
        {
            await db.SaveChangesAsync();
        }
    }
}

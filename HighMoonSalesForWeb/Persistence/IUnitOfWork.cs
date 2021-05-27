using Covid19_Services_Backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Persistence
{


    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}

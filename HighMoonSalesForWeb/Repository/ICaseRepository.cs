using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;
using Covid19_Services_Backend.Controllers.Resources;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Repository
{
    public interface ICaseRepository
    {

        Task<Case> Get(int id);
        Task<QueryResult<Case>> GetAll(FilterCase filter);
        Task<Case> Add(Case cas);
        Task<bool> Delete(int id);
        Case Update(Case lead);

        Task<QueryResult<Case>> GetSummaryCasesByDay(FilterCase filter);

    }
}

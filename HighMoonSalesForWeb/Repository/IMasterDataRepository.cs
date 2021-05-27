using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models;

namespace Covid19_Services_Backend.Repository
{
    public interface IMasterDataRepository
    {

        Task<IEnumerable<Country>> GetCountry();
        Task<IEnumerable<StatusOfCase>> GetStatus();


    }
}

using AutoMapper;
using Covid19_Services_Backend.Controllers.Resources;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;
using Covid19_Services_Backend.Controllers.Resources;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Covid19_Services_Backend.Models.SummaryCovidPerDay;

namespace Covid19_Services_BackendMapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap(typeof(QueryResult<>), typeof(QueryResultcsResource<>));

            CreateMap<StatusOfCase, KeyValuePairResource>().ForMember(r => r.Id, opt => opt.MapFrom(l => l.StatusOfCaseId));
            CreateMap<Country, KeyValuePairResource>()
                .ForMember(r => r.Id, opt => opt.MapFrom(l => l.CountryId ))
                .ForMember(r => r.Name, opt => opt.MapFrom(l => l.Name));


            CreateMap<Country, CountryResource>();
            CreateMap<CountrySaveResource, Country>();

            //CreateMap<SummaryCovidPerDay, SummaryCovidPerDayResource>();

            CreateMap<CaseSaveResource, Case>();
            CreateMap<Case, CaseSaveResource > ();

            CreateMap<Case, CaseResource>();
            CreateMap<CaseResource,Case >();

            CreateMap<FilterCaseResource, FilterCase>();




        }
    }
}

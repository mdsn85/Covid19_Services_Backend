using AutoMapper;
using Covid19_Services_Backend.Controllers.Resources;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Context;


using Covid19_Services_Backend.Persistence;
using Covid19_Services_Backend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Covid19_Services_BackendControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataController : ControllerBase
    {
        private readonly IMasterDataRepository masterDataRepository;
        private readonly IMapper mapper;

        public MasterDataController(IMasterDataRepository  masterDataRepository,IMapper mapper)
        {
            this.masterDataRepository = masterDataRepository;
            this.mapper = mapper;
        }

        [HttpGet("GetCountry")]
        public async Task<IActionResult> GetCountry()
        {
            var data = await masterDataRepository.GetCountry();
            var res = mapper.Map<List<Country>, List<KeyValuePairResource>>(data.ToList());
            return Ok(res);
        }

        [HttpGet("GetStatus")]
        public async Task<IActionResult> gets()
        {
            var data = await masterDataRepository.GetStatus();
            var res = mapper.Map<List<StatusOfCase>, List<KeyValuePairResource>>(data.ToList());
            return Ok(res);
        }



    }
}
/*
Task<IEnumerable<ModeOfLead>> GetModeOfLead();
Task<IEnumerable<NatureOfBusiness>> GetNatureOfBusiness();
Task<IEnumerable<Area>> GetArea();
Task<IEnumerable<StatusOFLead>> GetAreaStatusOFLeadId();
Task<IEnumerable<SalesMan>> GetSalesMan();*/
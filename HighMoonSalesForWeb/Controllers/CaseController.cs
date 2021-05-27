using AutoMapper;
using Covid19_Services_Backend.Controllers.Resources;
using Covid19_Services_Backend.Models;
using Covid19_Services_Backend.Models.Fillter;

using Covid19_Services_Backend.Persistence;
using Covid19_Services_Backend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_BackendControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private readonly ICaseRepository caseRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitofwork;

        public CaseController(ICaseRepository caseRepository,IMapper mapper,
            IUnitOfWork unitofwork)
        {
            this.caseRepository = caseRepository;
            this.mapper = mapper;
            this.unitofwork = unitofwork;
        }


        [HttpGet]
       // [HttpGet("")]
        public async Task<IActionResult> get([FromQuery] FilterCaseResource filterCaseResource)
        {
            FilterCase filter = mapper.Map<FilterCaseResource, FilterCase>(filterCaseResource);
            var queryResult =  await caseRepository.GetAll(filter);



            var result = mapper.Map<QueryResult<Case>, QueryResultcsResource<CaseResource>>(queryResult);

            return Ok( result);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> get(int id)
        {
            var lead = await caseRepository.Get(id);
            if(lead == null)  
                return BadRequest("Lead Not Found"); 
            var result = mapper.Map<Case, CaseSaveResource>(lead);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CaseSaveResource caseSaveResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var Case = mapper.Map<CaseSaveResource,Case>(caseSaveResource);


            await caseRepository.Add(Case);

            await unitofwork.SaveChanges();

            var result = mapper.Map<Case, CaseResource>(Case);

            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CaseSaveResource leadSaveResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var Case = await caseRepository.Get(id);

            if (Case == null)
                return BadRequest("Lead Not Found");

            mapper.Map<CaseSaveResource, Case>(leadSaveResource,Case);



            caseRepository.Update(Case);
            await unitofwork.SaveChanges();

            var result = mapper.Map<Case,CaseSaveResource>(Case);

            return Ok(result);

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await caseRepository.Delete(id);
            return Ok(new { result });

        }
    }
}


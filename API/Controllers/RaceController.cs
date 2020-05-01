using Contracts;
using Models.RaceModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/race")]
    public class RaceController : ApiController
    {
        private IRaceService _service;
        [HttpPost]
        [Route("create")]
        public IHttpActionResult Create(RaceCreateModel raceToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new RaceService();
            _service.CreateRace(raceToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("{raceId:int}")]
        public IHttpActionResult GetDetail([FromUri] int raceId)
        {
            _service = new RaceService();
            return Ok(_service.GetRaceDetailById(raceId));
        }
        [HttpGet]
        [Route("list")]
        public IHttpActionResult GetList()
        {
            _service = new RaceService();
            return Ok(_service.GetRaces());
        }
        [HttpPut]
        [Route("update/{raceId:int}")]
        public IHttpActionResult Update([FromBody] RaceUpdateModel raceToUpdate, [FromUri] int raceId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new RaceService();
            _service.UpdateRace(raceToUpdate, raceId);
            return Ok();
        }
        [HttpDelete]
        [Route("delete/{raceId:int}")]
        public IHttpActionResult Delete([FromUri] int raceId)
        {
            _service = new RaceService();
            _service.DeleteRace(raceId);
            return Ok();
        }
    }
}

using Contracts;
using Models.RaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class RaceController : ApiController
    {
        private readonly IRaceService _service;
        [HttpPost]
        public IHttpActionResult Create(RaceCreateModel raceToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service.CreateRace(raceToCreate);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetDetail(int raceId)
        {
            return Ok(_service.GetRaceDetailById(raceId));
        }
        [HttpGet]
        public IHttpActionResult GetList()
        {
            return Ok(_service.GetRaces());
        }
        [HttpPut]
        public IHttpActionResult Update(RaceUpdateModel raceToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service.UpdateRace(raceToUpdate);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(RaceDeleteModel raceToDelete)
        {
            _service.DeleteRace(raceToDelete);
            return Ok();
        }
    }
}

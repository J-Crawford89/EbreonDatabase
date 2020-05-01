using Contracts;
using Models.SubraceModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Permissions;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/subrace")]
    public class SubraceController : ApiController
    {
        private ISubraceService _service;
        [HttpPost]
        [Route("create")]
        public IHttpActionResult Create(SubraceCreateModel subraceToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new SubraceService();
            _service.CreateSubrace(subraceToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("{subraceId:int}")]
        public IHttpActionResult GetDetail([FromUri] int subraceId)
        {
            _service = new SubraceService();

            return Ok(_service.GetSubraceDetailById(subraceId));
        }
        [HttpGet]
        [Route("list/{raceId:int}")]
        public IHttpActionResult GetList([FromUri] int raceId)
        {
            _service = new SubraceService();

            return Ok(_service.GetSubracesByParentRace(raceId));
        }
        [HttpPut]
        [Route("update/{subraceId:int}")]
        public IHttpActionResult Update(SubraceUpdateModel subraceToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new SubraceService();

            _service.UpdateSubrace(subraceToUpdate);
            return Ok();
        }
        [HttpDelete]
        [Route("delete/{subraceId:int}")]
        public IHttpActionResult Delete(SubraceDeleteModel subraceToDelete)
        {
            _service = new SubraceService();

            _service.DeleteSubrace(subraceToDelete);
            return Ok();
        }
    }
}

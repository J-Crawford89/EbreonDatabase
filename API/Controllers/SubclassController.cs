using Contracts;
using Models.SubclassModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/subclass")]
    public class SubclassController : ApiController
    {
        private ISubclassService _service;
        [HttpPost]
        [Route("create")]
        public IHttpActionResult Create(SubclassCreateModel subclassToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new SubclassService();
            _service.CreateSubclass(subclassToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("{subclassId:int}")]
        public IHttpActionResult GetDetail([FromUri] int subclassId)
        {
            _service = new SubclassService();
            return Ok(_service.GetSubclassDetailById(subclassId));
        }
        [HttpGet]
        [Route("list/{classId:int}")]
        public IHttpActionResult GetList([FromUri] int classId)
        {
            _service = new SubclassService();
            return Ok(_service.GetSubclassesByParentClass(classId));
        }
        [HttpPut]
        [Route("update/{subclassId:int}")]
        public IHttpActionResult Update([FromBody] SubclassUpdateModel subclassToUpdate, [FromUri] int subclassId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new SubclassService();
            _service.UpdateSubclass(subclassToUpdate, subclassId);
            return Ok();
        }
        [HttpDelete]
        [Route("delete/{subclassId:int}")]
        public IHttpActionResult Delete([FromUri] int subclassId)
        {
            _service = new SubclassService();
            _service.DeleteSubclass(subclassId);
            return Ok();
        }
    }
}
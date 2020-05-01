using Contracts;
using Models.ClassModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/class")]
    public class ClassController : ApiController
    {
        private IClassServicecs _service;
        [HttpPost]
        [Route("create")]
        public IHttpActionResult Create(ClassCreateModel classToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new ClassService();
            _service.CreateClass(classToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("{classId:int}")]
        public IHttpActionResult GetDetail([FromUri] int classId)
        {
            _service = new ClassService();
            return Ok(_service.GetClassDetailById(classId));
        }
        [HttpGet]
        [Route("list")]
        public IHttpActionResult GetList()
        {
            _service = new ClassService();
            return Ok(_service.GetClasses());
        }
        [HttpPut]
        [Route("update/{classId:int}")]
        public IHttpActionResult Update([FromBody] ClassUpdateModel classToUpdate, [FromUri] int classId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new ClassService();
            _service.UpdateClass(classToUpdate, classId);
            return Ok();
        }
        [HttpDelete]
        [Route("delete/{classId:int}")]
        public IHttpActionResult Delete([FromUri] int classId)
        {
            _service = new ClassService();
            _service.DeleteClass(classId);
            return Ok();
        }
    }
}

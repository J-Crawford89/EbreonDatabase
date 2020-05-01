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
    public class ClassController : ApiController
    {
        private IClassServicecs _service;
        [HttpPost]
        public IHttpActionResult Create(ClassCreateModel classToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new ClassService();
            _service.CreateClass(classToCreate);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetDetail(int classId)
        {
            _service = new ClassService();
            return Ok(_service.GetClassDetailById(classId));
        }
        [HttpGet]
        public IHttpActionResult GetList()
        {
            _service = new ClassService();
            return Ok(_service.GetClasses());
        }
        [HttpPut]
        public IHttpActionResult Update(ClassUpdateModel classToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new ClassService();
            _service.UpdateClass(classToUpdate);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(ClassDeleteModel classToDelete)
        {
            _service = new ClassService();
            _service.DeleteClass(classToDelete);
            return Ok();
        }
    }
}

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
    public class SubclassController : ApiController
    {
        private ISubclassService _service;
        [HttpPost]
        public IHttpActionResult Create(SubclassCreateModel subclassToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new SubclassService();
            _service.CreateSubclass(subclassToCreate);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetDetail(int subClassId)
        {
            _service = new SubclassService();
            return Ok(_service.GetSubclassDetailById(subClassId));
        }
        [HttpGet]
        public IHttpActionResult GetList(int classId)
        {
            _service = new SubclassService();
            return Ok(_service.GetSubclassesByParentClass(classId));
        }
        [HttpPut]
        public IHttpActionResult Update(SubclassUpdateModel subclassToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _service = new SubclassService();
            _service.UpdateSubclass(subclassToUpdate);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(SubclassDeleteModel subclassToDelete)
        {
            _service = new SubclassService();
            _service.DeleteSubclass(subclassToDelete);
            return Ok();
        }
    }
}
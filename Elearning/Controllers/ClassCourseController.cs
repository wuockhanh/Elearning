using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;

using Elearning.DBContext;
using Elearning.Entity;
using Elearning.Respository;
using AutoMapper;
using Elearning.DTO;
namespace Elearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassCourseController : ControllerBase
    {
        private IEClassCourseRespository _CCRespo;
        private IMapper ccmap;

        public ClassCourseController(IEClassCourseRespository ccrespo, IMapper mapper)
        {
            ccmap = mapper;
            _CCRespo = ccrespo;
        }

        
        //GET
        [HttpGet]
        public async Task<ActionResult<List<Class_CourseDTO>>> getAllCourse()
        {
            var model = _CCRespo.GetAll();
            if (model == null)
            {
                return new List<Class_CourseDTO>();
            }
            return model.ToList();
        }

        //POST
        [HttpPost]
        public ActionResult<bool> AddCourse(Class_CourseDTO model)
        {
            var check = _CCRespo.Insert(model);
            _CCRespo.Save();
            return check;

        }

        //PUT
        [HttpPut]
        public ActionResult<bool> UpdateCourse(Class_CourseDTO model)
        {
            var check = _CCRespo.Update(model);
            _CCRespo.Save();
            return check;

        }


        //DELETE
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCourse(int id)
        {
            var check = _CCRespo.Delete(id);

            _CCRespo.Save();
            return check;

        }
    }
}

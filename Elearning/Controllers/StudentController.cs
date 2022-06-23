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
    public class StudentController : ControllerBase
    {
        private IEStudent _StuRespo;
        private IMapper stumap;
        public StudentController(IEStudent sturespo, IMapper mapper)
        {
            stumap = mapper;
            _StuRespo = sturespo;

        }

        //GET
        [HttpGet]
        public async Task<ActionResult<List<StudentDTO>>> getStu()
        {
            var model = _StuRespo.GetAll();
            if (model == null)
            {
                return new List<StudentDTO>();
            }
            return model.ToList();
        }

        //POST
        [HttpPost]
        public ActionResult<bool> AddStu(StudentDTO model)
        {
            var check = _StuRespo.Insert(model);
            _StuRespo.Save();
            return check;

        }


        //PUT
        [HttpPut]
        public ActionResult<bool> UpdateStu(StudentDTO model)
        {
            var check = _StuRespo.Update(model);
            _StuRespo.Save();
            return check;

        }


        //DELETE
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteAdmin(string id)
        {
            var check = _StuRespo.Delete(id);

            _StuRespo.Save();
            return check;

        }
    }
}

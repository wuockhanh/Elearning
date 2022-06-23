using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Elearning.DTO;
using Elearning.Entity;
namespace Elearning.Respository
{
    public interface IEClassCourseRespository
    {
        List<Class_CourseDTO> GetAll();
        Class_CourseDTO GetById(int lassCourseId);
        bool Insert(Class_CourseDTO class_Course);
        bool Update(Class_CourseDTO class_Course);
        bool Delete(int lassCourseId);
        void Save();
    }
}

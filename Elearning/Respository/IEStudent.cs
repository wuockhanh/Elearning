using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Elearning.Entity;
using Elearning.DTO;
namespace Elearning.Respository
{
    public interface IEStudent
    {
        List<StudentDTO> GetAll();
        StudentDTO GetById(string studentId);
        bool Insert(StudentDTO student);
        bool Update(StudentDTO student);
        bool Delete(string studentId);
        void Save();
    }
}

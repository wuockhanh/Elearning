﻿using System;
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
    public interface IEClassRespository
    {
        List<ClassDTO> GetAll();
        ClassDTO GetById(string classId);
        bool Insert(ClassDTO classes);
        bool Update(ClassDTO classes);
        bool Delete(string classId);
        void Save();
    }
}

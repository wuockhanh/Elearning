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
    public interface IEAdminAccRespository
    {
        List<AdminAccountDTO> GetAll();
        AdminAccountDTO GetByUser(string userName);
        bool Insert(AdminAccountDTO adminaccount);
        bool Update(AdminAccountDTO adminaccount);
        bool Delete(string userName);
        void Save();
    }
}

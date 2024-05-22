using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Entities;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();

            CreateMap<Role, RoleDTO>().ReverseMap();

        }

    }
}       

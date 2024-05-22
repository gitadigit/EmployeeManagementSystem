using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.DTOs
{

    public enum RoleName { Maneger, Teacher }

    public  class RoleDTO
    {
        public int Id { get; set; }

        public RoleName RoleName { get; set; }

        public DateTime DateEntryOffice { get; set; }
    }
}

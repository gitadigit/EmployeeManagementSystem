using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{

    public enum RoleName { Maneger, Teacher }

    public class Role
    {
        public int Id { get; set; }

        public RoleName RoleName { get; set; }

        public DateTime DateEntryOffice {  get; set; }
   
    }
}

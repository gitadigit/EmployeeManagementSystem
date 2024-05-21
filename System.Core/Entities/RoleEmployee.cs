using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class RoleEmployee
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int RoleId { get; set; }

        public DateTime DateStartingWork { get; set; }

        public bool IsManager { get; set; }

    }
}

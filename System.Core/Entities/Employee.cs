﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{

    public enum Gender { Male, Female }

    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TZ { get; set; }

        public DateTime StartWorkDate { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public bool IsActive { get; set; }

        //
        public List<RoleEmployee> EmployeesRole { get; set; }
    }
}

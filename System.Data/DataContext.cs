using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace System.Data
{
    public class DataContext:DbContext
    {

        public DbSet<Employee> EmployeeList { get; set; }

        public DbSet<Role> RoleList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DBEmployeeManagement");

            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

    }
}


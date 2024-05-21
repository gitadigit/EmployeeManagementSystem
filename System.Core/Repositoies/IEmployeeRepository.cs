using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        Employee AddEmployee(Employee employee);

        Employee UpdaateEmployee(int id, Employee employee);

        void DeleteEmployee(int id);    

    }
}

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

        Task<Employee> AddEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(int id, Employee employee);

        Task<Employee> DeleteEmployeeAsync(int id);
    }
}

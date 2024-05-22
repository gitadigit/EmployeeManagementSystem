using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        Task<Employee> AddEmployeeAsync(Employee employee);

        Task<Employee> UpdaateEmployeeAsync(int id, Employee employee);

        Task<Employee> DeleteEmployeeAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task<Employee> UpdaateEmployeeAsync(int id, Employee employee)
        {
            return await _employeeRepository.UpdateEmployeeAsync(id, employee);
        }

        public async Task<Employee> DeleteEmployeeAsync(int id)
        {
           return await _employeeRepository.DeleteEmployeeAsync(id);
        }

    }
}

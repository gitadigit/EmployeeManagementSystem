using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees()
        {
            return _context.EmployeeList.Include(e => e.EmployeesRole).ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.EmployeeList.Include(e => e.EmployeesRole).ToList().First(e => e.Id == id);
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            _context.EmployeeList.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        {
            var updataEmployee = _context.EmployeeList.First(e => e.Id == id);
            if (updataEmployee != null)
            {
                updataEmployee.LastName = employee.LastName;
                updataEmployee.FirstName = employee.FirstName;
                updataEmployee.TZ = employee.TZ;
                updataEmployee.StartWorkDate = employee.StartWorkDate;
                updataEmployee.BirthDate = employee.BirthDate;
                updataEmployee.Gender = employee.Gender;
                updataEmployee.IsActive = employee.IsActive;
                await _context.SaveChangesAsync();
                return updataEmployee;
            }
            return null;
        }

        public async Task<Employee> DeleteEmployeeAsync(int id)
        {
            var employeToDelete = _context.EmployeeList.FirstOrDefault(e => e.Id == id);

            if (employeToDelete != null)
                employeToDelete.IsActive= false;    

            await _context.SaveChangesAsync();
            return employeToDelete;
        }

    }
}

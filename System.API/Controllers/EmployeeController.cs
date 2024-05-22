using System.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // private readonly DataContext _context = new DataContext();
        private readonly IEmployeeService _employeeService;

        //private readonly Mapping _mapping;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }



        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult Get()
        {

            var allEmployee = _employeeService.GetEmployees();
            var allEmployeeDto = new List<EmployeeDTO>();

            foreach (var e in allEmployee)
                allEmployeeDto.Add(_mapper.Map<EmployeeDTO>(e));

            return Ok(allEmployeeDto); ;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            var employeeDbt = _mapper.Map<EmployeeDTO>(employee);
            if (employeeDbt is null)
            {
                return NotFound();
            }
            return Ok(employeeDbt);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePostModel employee)
        {
            var employeeToAdd = _mapper.Map<Employee>(employee);

            var employeeAdd = await _employeeService.AddEmployeeAsync(employeeToAdd);

            var employeeDto = _mapper.Map<EmployeeDTO>(employee);

            if (employeeDto is null)
                return NotFound();

            return Ok(employeeDto);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeePostModel employee)
        {
            var employeeToUpdate = _employeeService.GetEmployeeById(id);

            if (employeeToUpdate is null)
                return NotFound();

            _mapper.Map(employee, employeeToUpdate);

            var employeeUpdate = await _employeeService.UpdaateEmployeeAsync(id, employeeToUpdate);

            var employeUpdateDto = _mapper.Map<EmployeeDTO>(employeeUpdate);

            return Ok(employeUpdateDto);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {

            var employeeDelete = await _employeeService.DeleteEmployeeAsync(id);
            if (employeeDelete is null)
                return NotFound();

            return Ok(employeeDelete);
        }
    }
}


using System.Data;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // private readonly DataContext _context = new DataContext();
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeeService.GetEmployees()); ;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);

        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if(employee is null)
            {
                return NotFound();
            }
            return Ok(_employeeService.AddEmployee(employee)); 
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if(employee is null)
            {
                return BadRequest();
            }
           return Ok(_employeeService.UpdaateEmployee(id, employee));
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}

using System.Data;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        //private readonly DataContext _context = new DataContext();

        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: api/<RoleController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roleService.GetRoles());
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var role =_roleService.GetRoleById(id);
            if(role is null )
            {
                return NotFound();  
            }
            return Ok(role);
        }

        // POST api/<RoleController>
        [HttpPost]
        public IActionResult Post([FromBody] Role role)
        {
            if(role is null)
            {
                return NotFound();
            }
           return Ok(_roleService.AddRole(role));  
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Role role)
        {
            if(role is null )
                return NotFound();
           return Ok(_roleService.UpdateRole(id, role));
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleService.DeleteRole(id);
        }
    }
}

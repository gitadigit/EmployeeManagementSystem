using System.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        //private readonly DataContext _context = new DataContext();

        private readonly IRoleService _roleService;

        private readonly IMapper _mapper;   

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        // GET: api/<RoleController>
        [HttpGet]
        public ActionResult Get()
        {
            var allRole = _roleService.GetRoles();
            
            var roleDto = new List<RoleDTO>();

            foreach (var r in allRole)

                roleDto.Add(_mapper.Map<RoleDTO>(r));

            return Ok(roleDto);
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var role = _roleService.GetRoleById(id);

            var roleDto = _mapper.Map<RoleDTO>(role);

            if (role is null)
            {
                return NotFound();
            }
            return Ok(role);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RolePostModel role)
        {
            var roleToAdd = _mapper.Map<Role>(role);

            var roleAdd = await _roleService.AddRoleAsync(roleToAdd);

            var roleAddDto = _mapper.Map<RoleDTO>(roleAdd);

            if (roleAddDto is null)
                return NotFound();
            return Ok(roleAddDto);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] RolePostModel role)
        {
            var roleToUpdate = _roleService.GetRoleById(id);

            if (roleToUpdate is null)
                return NotFound();

            _mapper.Map(role, roleToUpdate);

            var roleUpdate = await _roleService.UpdateRoleAsync(id, roleToUpdate);

            var roleUpdateDto = _mapper.Map<RoleDTO>(roleUpdate);

            return Ok(roleUpdateDto);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult > Delete(int id)
        {
            var roleDelete = await _roleService.DeleteRoleAsync(id);
            if (roleDelete is null)
                return NotFound();

            return Ok(roleDelete);
        }
    }
}

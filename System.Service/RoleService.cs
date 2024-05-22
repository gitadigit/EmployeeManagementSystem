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
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public List<Role> GetRoles()
        {
            return _roleRepository.GetRoles();
        }

        public Role GetRoleById(int id)
        {
            return _roleRepository.GetRoleById(id);
        }

        public  async Task<Role> AddRoleAsync(Role role)
        {
           return await _roleRepository.AddRoleAsync(role);
        }
        public async Task<Role> UpdateRoleAsync(int id, Role role)
        {
            return await _roleRepository.UpdateRoleAsync(id, role);
        }

        public async Task<Role> DeleteRoleAsync(int id)
        {
          return await  _roleRepository.DeleteRoleAsync(id);
        }

    }
}

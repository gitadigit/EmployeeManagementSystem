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

        public Role AddRole(Role role)
        {
           return _roleRepository.AddRole(role);
        }

        public Role UpdateRole(int id, Role role)
        {
           return _roleRepository.UpdateRole(id, role);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.DeleteRole(id);
        }

    }
}

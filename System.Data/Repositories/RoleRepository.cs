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
    public class RoleRepository: IRoleRepository
    {
        private readonly DataContext _context;

        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public List<Role> GetRoles()
        {
            return _context.RoleList.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _context.RoleList.First(r => r.Id == id);
        }

        public Role AddRole(Role role)
        {
            _context.RoleList.Add(role);
            return role;
        }

        public Role UpdateRole(int id, Role role)
        {
            var updataRole = _context.RoleList.ToList().Find(r => r.Id == id);

            if (updataRole != null)
            {
                updataRole.RoleName = role.RoleName;
                updataRole.DateEntryOffice = role.DateEntryOffice;
            }

            return null;
        }

        public void DeleteRole(int id)
        {
            _context.RoleList.Remove(_context.RoleList.ToList().Find(r => r.Id == id));
        }

    }
}

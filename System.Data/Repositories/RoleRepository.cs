using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Role> AddRoleAsync(Role role)
        {
            _context.RoleList.Add(role);
           await _context.SaveChangesAsync();    
            return role;
        }

        public async Task<Role> UpdateRoleAsync(int id, Role role)
        {
            var updataRole = _context.RoleList.ToList().Find(r => r.Id == id);

            if (updataRole != null)
            {
                updataRole.RoleName = role.RoleName;
                updataRole.DateEntryOffice = role.DateEntryOffice;
               await  _context.SaveChangesAsync();
                return updataRole;  
            }

            return null;
        }

        public async Task<Role> DeleteRoleAsync(int id)
        {
           var roleToDelete =  _context.RoleList.FirstOrDefault(r => r.Id == id);
           
           
           await _context.SaveChangesAsync();
            return roleToDelete;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IRoleRepository
    {
        List<Role> GetRoles();

        Role GetRoleById(int id);

        Task<Role> AddRoleAsync(Role role);

        Task<Role> UpdateRoleAsync(int id, Role role);

        Task<Role> DeleteRoleAsync(int id);

    }
}

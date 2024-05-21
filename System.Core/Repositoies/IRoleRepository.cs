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

        Role AddRole(Role role);

        Role UpdateRole(int id, Role role);

        void DeleteRole(int id);

    }
}

using Solid.Core.Entities;

namespace Solid.API.Models
{

    public enum Gender { Male, Female }

    public class EmployeePostModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TZ { get; set; }

        public DateTime StartWorkDate { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public bool IsActive { get; set; }

        //
        public List<RoleEmployee> EmployeesRole { get; set; }
    }
}

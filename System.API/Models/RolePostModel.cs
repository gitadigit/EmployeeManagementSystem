namespace Solid.API.Models
{
    public enum RoleName { Maneger, Teacher }

    public class RolePostModel
    {
        public RoleName RoleName { get; set; }

        public DateTime DateEntryOffice { get; set; }

    }
}

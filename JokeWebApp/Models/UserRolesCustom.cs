using JokeWebApp.Enum;

namespace JokeWebApp.Models
{
    public class UserRolesCustom
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Auto-generate GUIDs
        public Guid UserId { get; set; } // Foreign Key to Users table
        public RoleType Role { get; set; } // Enum for role types
        public UserCustom User { get; set; } // Navigation Property
    }

}

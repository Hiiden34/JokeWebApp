namespace JokeWebApp.Models
{
    public class UserCustom
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Auto-generate GUIDs
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
    }
}

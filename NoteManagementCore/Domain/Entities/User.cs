using NoteManagementCore.Domain.Enums;

namespace NoteManagementCore.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public Role Role { get; set; } = Role.User;

        public ICollection<Note>? Notes { get; set; }
    }
}
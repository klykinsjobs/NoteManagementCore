using NoteManagementCore.Domain.Enums;

namespace NoteManagementCore.Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public Role Role { get; set; }
    }
}
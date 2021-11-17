using Microsoft.AspNetCore.Identity;

namespace DiemDanhOTP.Core.Domain
{
    public class User: IdentityUser
    {
        public int? Role { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsAdmin { get; set; }
        public string? StudentId { get; set; }
        public string? TeacherId { get; set; }
        
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}

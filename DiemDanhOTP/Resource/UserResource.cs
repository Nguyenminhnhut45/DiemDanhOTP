using DiemDanhOTP.Core.Domain;

namespace DiemDanhOTP.Resource
{
    public class UserResource
    {
        public string? Usename { get; set; }
        public string? Role { get; set; }
        public bool IsAdmin { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}

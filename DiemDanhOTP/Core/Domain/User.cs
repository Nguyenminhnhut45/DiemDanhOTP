﻿using Microsoft.AspNetCore.Identity;

namespace DiemDanhOTP.Core.Domain
{
    public class User: IdentityUser
    {
        public User()
        {
            Student = new Student();
            Teacher = new Teacher();
        }

        public string? Usename { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public bool IsAdmin { get; set; }
        
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
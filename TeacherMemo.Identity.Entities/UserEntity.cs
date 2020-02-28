using Microsoft.AspNetCore.Identity;
using System;

namespace TeacherMemo.Identity.Entities
{
    public class UserEntity : IdentityUser<Guid>
    {
        public string Role { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherMemo.Services.Abstract;

namespace TeacherMemo.Services.Implementation
{
    public class UserService : IUserService
    {
        public Guid CurrentUserId
        {
            get
            {
                var userClaim = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "userId");
                var userId = Guid.Parse(userClaim.Value);
                return userId;
            }
        }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}

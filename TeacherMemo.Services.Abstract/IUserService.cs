using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherMemo.Services.Abstract
{
    public interface IUserService
    {
        Guid CurrentUserId { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherMemo.Identity.Entities
{
    public static class Roles
    {
        public const string Admin = "ADMIN";
        public const string Teacher = "TEACHER";
        public const string HeadDepartment = "HEAD";

        public const string All = Teacher + ", " + Admin + ", " + HeadDepartment;
    }
}

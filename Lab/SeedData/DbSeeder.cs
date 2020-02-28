using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using TeacherMemo.Identity.Entities;
using TeacherMemo.Persistence.Implementation;

namespace Lab.SeedData
{
    public class DbSeeder : IDbSeeder
    {
        private readonly MemoContext _context;
        private readonly UserManager<UserEntity> _userManager;

        public DbSeeder(UserManager<UserEntity> userManager, MemoContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task SeedData()
        {
            await GenerateUser("admin@gmail.com", "1234", Roles.Admin);
            await GenerateUser("head@gmail.com", "1234", Roles.HeadDepartment);
            await GenerateUser("teacher@gmail.com", "1234", Roles.Teacher);
        }

        private async Task GenerateUser(string email, string password, string role)
        {
            if (!_context.Users.Any(x => x.Role == role))
            {
                var user = CreateUser(email);
                await _userManager.CreateAsync(user, password);
                await _userManager.AddToRoleAsync(user, role);
            }

            UserEntity CreateUser(string email) => new UserEntity
            {
                Email = email,
                UserName = email
            };
        }
    }
}

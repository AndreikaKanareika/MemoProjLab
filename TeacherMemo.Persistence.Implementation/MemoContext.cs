using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TeacherMemo.Identity.Entities;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Implementation
{
    public class MemoContext : IdentityDbContext<UserEntity, IdentityRole<Guid>, Guid>
    {
        public DbSet<MemoEntity> Memos { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<SubjectEntity> Subjects { get; set; }

        public MemoContext(DbContextOptions<MemoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MemoEntityConfiguration());
            base.OnModelCreating(builder);
        }
    }
}

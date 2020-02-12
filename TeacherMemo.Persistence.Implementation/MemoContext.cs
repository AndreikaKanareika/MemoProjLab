using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Implementation
{
    public class MemoContext : DbContext
    {
        public DbSet<MemoEntity> Memos { get; set; }

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

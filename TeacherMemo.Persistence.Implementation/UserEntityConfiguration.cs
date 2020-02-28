using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeacherMemo.Identity.Entities;

namespace TeacherMemo.Persistence.Implementation
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users")
                .HasKey(x => x.Id)
                .IsClustered();
        }
    }
}

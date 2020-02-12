using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Implementation
{
    public class MemoEntityConfiguration : IEntityTypeConfiguration<MemoEntity>
    {
        public void Configure(EntityTypeBuilder<MemoEntity> builder)
        {
            builder.ToTable("Memos")
                .HasKey(x => x.Id)
                .IsClustered();
        }
    }
}

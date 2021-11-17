using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.HasOne(x => x.User).WithOne(x => x.Teacher).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.GroupSubjects).WithOne(x => x.Teacher).OnDelete(DeleteBehavior.Cascade);

        }
    }
}

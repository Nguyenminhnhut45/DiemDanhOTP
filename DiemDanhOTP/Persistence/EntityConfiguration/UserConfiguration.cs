using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Student).WithOne(x => x.User).HasForeignKey<User>(x => x.StudentId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Teacher).WithOne(x => x.User).HasForeignKey<User>(x => x.TeacherId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

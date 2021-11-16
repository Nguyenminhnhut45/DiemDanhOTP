using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.SessionDetails);
            builder.HasMany(x => x.Studies);
            builder.HasOne(x => x.User).WithOne(x => x.Student).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

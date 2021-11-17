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
            
            builder.HasOne(x => x.User).WithOne(x => x.Student).HasForeignKey<Student>(x => x.IdUser).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x=> x.SessionDetails).WithOne(x=>x.Student).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Studies).WithOne(x => x.Student).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

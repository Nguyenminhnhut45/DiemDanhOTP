using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class GroupSubjectConfiguration : IEntityTypeConfiguration<GroupSubject>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GroupSubject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=> x.Course);
            builder.HasOne(x => x.Teacher);
            builder.HasMany(x => x.Sessions).WithOne(x=>x.GroupSubject);
            builder.HasMany(x => x.Studies).WithOne(x => x.GroupSubject);


        }
    }
}

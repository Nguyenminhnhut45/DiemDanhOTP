using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class StudyConfiguration : IEntityTypeConfiguration<Study>
    {
        public void Configure(EntityTypeBuilder<Study> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(a => a.Student).WithMany(i => i.Studies).HasForeignKey(a => a.IdStudent);
            builder.HasOne(a => a.GroupSubject).WithMany(i => i.Studies).HasForeignKey(a => a.IdGroupSubject);

        }
    }
}

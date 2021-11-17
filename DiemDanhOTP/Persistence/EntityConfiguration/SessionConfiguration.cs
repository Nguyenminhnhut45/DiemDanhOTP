using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.GroupSubject);

            builder.HasOne(x => x.GroupSubject).WithMany(x=> x.Sessions).HasForeignKey(x=>x.IdGroup);
            
        }
    }
}

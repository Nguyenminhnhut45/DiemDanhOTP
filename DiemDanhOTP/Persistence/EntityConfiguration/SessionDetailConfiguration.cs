

using DiemDanhOTP.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiemDanhOTP.Persistence.EntityConfiguration
{
    public class SessionDetailConfiguration : IEntityTypeConfiguration<SessionDetail>
    {
        public void Configure(EntityTypeBuilder<SessionDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Student).WithMany(x=>x.SessionDetails).HasForeignKey(x=>x.IdStuddent);
            builder.HasOne(x => x.Session).WithMany(x => x.SessionDetails).HasForeignKey(x => x.IdSession);

        }
    }
}

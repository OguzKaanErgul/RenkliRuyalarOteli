using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entities.Concrete;

namespace RenkliRuyalarOteli.DAL.EntityTypeConfiguration
{
    public class KullaniciConfiguration : BaseEntityConfiguration<Kullanici>
    {
        public override void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.Property(p => p.Email).HasMaxLength(30);
            builder.Property(p => p.TcNo).HasMaxLength(11);

            base.Configure(builder);
        }
    }
}

﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entities.Concrete;

namespace RenkliRuyalarOteli.DAL.EntityTypeConfiguration
{
    public class KullaniciConfiguration : BaseEntityConfiguration<Kullanici>
    {
        public override void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Email).HasMaxLength(30);
            builder.Property(p => p.TcNo).HasMaxLength(11);
            builder.Property(p => p.Adi).HasMaxLength(20);
            builder.Property(p => p.Soyadi).HasMaxLength(20);
            builder.Property(p => p.KullaniciAdi).HasMaxLength(20);
            builder.HasIndex(p => p.KullaniciAdi).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.TcNo).IsUnique();

        }
    }
}

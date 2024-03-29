﻿using RenkliRuyalarOteli.Entities.Entities.Abstract;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{
    public class RezervasyonDetay : BaseEntity
    {
        public Guid RezervasyonId { get; set; }

        public Rezervasyon Rezervasyon { get; set; }

        public Guid MusteriId { get; set; }

        public Musteri Musteri { get; set; }

        public Guid KullaniciId { get; set; }

        public Kullanici Kullanici { get; set; }
    }
}

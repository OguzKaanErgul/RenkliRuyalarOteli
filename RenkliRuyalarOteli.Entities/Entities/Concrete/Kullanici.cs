﻿using RenkliRuyalarOteli.Entities.Entities.Abstract;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{
    public class Kullanici : BaseEntity
    {
        public string KullaniciAdi { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string TcNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public bool Cinsiyeti { get; set; }

        public DateTime DogumTarihi { get; set; }

        public ICollection<Role> Roller { get; set; }

        public ICollection<Musteri> Musteriler { get; set; }

        public ICollection<Oda> Odalar { get; set; }

        public ICollection<OdaFiyat> OdaFiyatlari { get; set; }

        public ICollection<Rezervasyon> Rezervasyonlari { get; set; }

        public ICollection<RezervasyonDetay> RezervasyonDetaylari { get; set; }

        public byte[] ImageData { get; set; }

        public string? ImageUrl { get; set; }

    }
}

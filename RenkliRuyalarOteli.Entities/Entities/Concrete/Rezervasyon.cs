using RenkliRuyalarOteli.Entities.Entities.Abstract;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{
    public class Rezervasyon : BaseEntity
    {
        //Odaya giris ve cikis tarihleri

        public DateTime GirisTarihi { get; set; }

        public DateTime CikisTarihi { get; set; }

        //Hangi odaya rezerve yapildigi

        public OdaFiyat OdaFiyat { get; set; }

        public Guid OdaFiyatId { get; set; }

        //Odanin o tarihteki fiyati

        public Guid OdaId { get; set; }

        public Oda Oda { get; set; }

        public ICollection<RezervasyonDetay> RezervasyonDetaylari { get; set; }

        public Guid KullaniciId { get; set; }

        public Kullanici Kullanici { get; set; }


    }
}

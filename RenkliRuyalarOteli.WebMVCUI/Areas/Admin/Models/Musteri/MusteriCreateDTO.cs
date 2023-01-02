using System.ComponentModel.DataAnnotations;

namespace RenkliRuyalarOteli.WebMVCUI.Areas.Admin.Models.Musteri
{
    public class MusteriCreateDTO
    {
        public string? MusteriAdi { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Girmek Zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "TcNo Zorunludur")]
        [MaxLength(11)]
        public string MusteriTcNo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "TelNo Zorunludur")]
        [DataType(DataType.PhoneNumber)]
        public string CepNo { get; set; }



        public string Ad { get; set; }

        public string Soyad { get; set; }

        public bool Cinsiyet { get; set; }





    }
}

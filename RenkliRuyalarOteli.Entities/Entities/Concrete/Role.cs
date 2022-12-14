using RenkliRuyalarOteli.Entities.Entities.Abstract;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{
    public class Role : BaseEntity
    {
        public string? RoleName { get; set; }

        public ICollection<Kullanici>? Kullanicilar { get; set; }
    }
}

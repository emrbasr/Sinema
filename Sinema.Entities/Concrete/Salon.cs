using Sinema.Entities.Abstract;

namespace Sinema.Entities.Concrete
{
    public class Salon : BaseEntity
    {
        public string SalonAdi { get; set; }
        public int Kapasite { get; set; }
        public ICollection<Gosterim> Gosterimler { get; set; }
    }
}

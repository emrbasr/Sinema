using Sinema.Entities.Abstract;

namespace Sinema.Entities.Concrete
{
    public class Hafta : BaseEntity
    {
        public string HaftaAdi { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public ICollection<Gosterim> Gosterimler { get; set; }
    }
}

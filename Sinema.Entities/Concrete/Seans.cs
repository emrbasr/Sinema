using Sinema.Entities.Abstract;

namespace Sinema.Entities.Concrete
{
    public class Seans : BaseEntity
    {
        public string SeansAdi { get; set; }
        public ICollection<Gosterim> Gosterimler { get; set; }
    }
}

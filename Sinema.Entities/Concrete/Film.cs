using Sinema.Entities.Abstract;

namespace Sinema.Entities.Concrete
{
    public class Film : BaseEntity
    {
        public string FilmAdi { get; set; }
        public string Aciklama { get; set; }
        public int Sure { get; set; }
        public ICollection<Kategori> Kategoriler { get; set; }
        public ICollection<Gosterim> Gosterimler { get; set; }
    }
}

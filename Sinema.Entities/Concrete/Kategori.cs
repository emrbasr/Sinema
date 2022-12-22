using Sinema.Entities.Abstract;

namespace Sinema.Entities.Concrete
{
    public class Kategori : BaseEntity
    {
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Film> Filmler { get; set; }

    }
}

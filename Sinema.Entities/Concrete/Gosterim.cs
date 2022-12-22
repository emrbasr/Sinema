using Sinema.Entities.Abstract;

namespace Sinema.Entities.Concrete
{
    public class Gosterim : BaseEntity
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }



        public int Hafta { get; set; }
        public Hafta Haftalar { get; set; }

        public int SeansId { get; set; }
        public Seans Seanslar { get; set; }

        public int SalonId { get; set; }
        public Salon Salonlar { get; set; }

    }
}

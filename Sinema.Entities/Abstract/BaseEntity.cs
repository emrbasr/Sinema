namespace Sinema.Entities.Abstract
{
    public enum Status
    {
        Active = 1,
        Update = 2,
        Delete = 3

    }
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }


        public string? KullaniciId { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}

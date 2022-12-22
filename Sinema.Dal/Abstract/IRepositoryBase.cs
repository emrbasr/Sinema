using Sinema.Entities.Abstract;

namespace Sinema.Dal.Abstract
{
    public interface IRepositoryBase<T> where T : BaseEntity, new()
    {
    }
}

using GenericApplication.Domain.Base;
using GenericApplication.Domain.Item;

namespace GenericApplication.Infrastructure.Persistence.Interface
{
    public interface IItemRepository : IRepository<Item>
    {
    }
}

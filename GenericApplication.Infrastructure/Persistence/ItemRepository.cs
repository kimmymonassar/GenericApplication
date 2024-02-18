using GenericApplication.Domain.Base;
using GenericApplication.Domain.Item;
using GenericApplication.Infrastructure.Persistence.Interface;

namespace GenericApplication.Infrastructure.Persistence;

public class ItemRepository(ItemDbContext context) : IItemRepository
{
    public IUnitOfWork UnitOfWork => context;

    public async Task<Item> Add(Item entity)
    {
        context.Items.Add(entity);
        return entity;
    }

    public async Task CommitAsync()
    {
        await context.SaveChangesAsync();
    }
}

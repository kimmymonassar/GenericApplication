using GenericApplication.Domain.Base;
using GenericApplication.Domain.Item;
using Microsoft.EntityFrameworkCore;

namespace GenericApplication.Infrastructure;

public class ItemDbContext : DbContext, IUnitOfWork
{
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options) { }

    public DbSet<Item> Items => Set<Item>();

    public Task<bool> SaveEntitiesAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Item>()
            .OwnsOne(product => product.Property, 
            d => { 
                d.ToJson();
                d.OwnsMany(d => d.Properties);
            });
    }
}

namespace GenericApplication.Domain.Base;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken token = default);
    Task<bool> SaveEntitiesAsync(CancellationToken token = default);
}

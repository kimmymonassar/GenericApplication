namespace GenericApplication.Domain.Base;

#pragma warning disable S2326 // Unused type parameters should be removed
public interface IRepository<T> where T : IAggregateRoot
#pragma warning restore S2326 // Unused type parameters should be removed
{
    IUnitOfWork UnitOfWork { get; }
    Task CommitAsync();
    Task<T> Add(T entity);
}

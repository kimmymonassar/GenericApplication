using MediatR;
namespace GenericApplication.Domain.Base;

public abstract class Entity
{
    public int Id { get; init; }

    public readonly List<INotification> DomainEvents = [];

    public void AddDomainEvent(INotification domainEvent)
    {
        DomainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent(INotification domainEvent)
    {
        DomainEvents.Remove(domainEvent);
    }

    public void ClearDomainEvents()
    {
        DomainEvents.Clear();
    }

    public bool IsTransient()
    {
        return Id == default;
    }
}

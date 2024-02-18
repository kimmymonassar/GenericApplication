using GenericApplication.Domain.Base;
using GenericApplication.Domain.ItemAggregate;

namespace GenericApplication.Domain.Item;

public class Item : Entity, IAggregateRoot
{
    public string? Name { get; set; }
    public ItemProperty? Property { get; set; }
}

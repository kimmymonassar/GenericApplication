using GenericApplication.API.Queries;
using GenericApplication.API.Responses;
using GenericApplication.Infrastructure.Persistence.Interface;
using MediatR;

namespace GenericApplication.API.Handlers;

using Domain.Item;
using GenericApplication.Domain.ItemAggregate;

public class GetAllHandler(IItemRepository repository) : IRequestHandler<GetAllQuery, GetAllResponse>
{
    public async Task<GetAllResponse> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var item = new Item
        {
            Name = "Item",
            Property = new ItemProperty
            {
                Name = "Random",
                Properties = [new ItemSubProperty { Price = 55m, ShippingAddress = "random add"}],
            }
        };

  
        await repository.Add(item);
        await repository.CommitAsync();

        return new GetAllResponse();
    }
}

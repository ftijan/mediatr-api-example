using Example.MediatR.Api.Context;
using Example.MediatR.Api.Context.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example.MediatR.Api.Cqrs
{
    public class GetItemRequest : IRequest<Item>
    {        
        public int Id { get; set; }
    }

    public class GetItemHandler : IRequestHandler<GetItemRequest, Item>
    {
        private readonly ApiContext _apiContext;

        public GetItemHandler(ApiContext apiContext)
        {
            _apiContext = apiContext ?? throw new ArgumentNullException(nameof(apiContext));
        }

        public async Task<Item> Handle(GetItemRequest request, CancellationToken cancellationToken)
        {
            var item = await _apiContext.Items.FindAsync(request.Id);

            return item;
        }
    }

}

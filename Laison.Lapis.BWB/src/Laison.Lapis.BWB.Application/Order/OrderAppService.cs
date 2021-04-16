using Laison.Lapis.BWB.Application.Contracts;
using Laison.Lapis.BWB.Domain.Entities;
using Laison.Lapis.BWB.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace Laison.Lapis.BWB.Application
{
    /// <summary>
    /// Order Application Service
    /// </summary>
    public class OrderAppService : BWBAppServiceBase, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderAppService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [UnitOfWork]
        public async Task CreateOrderAsync(CreateOrderInput input)
        {
            var order = new Order(GuidGenerator.Create(), input.CustomerId);

            foreach (var item in input.OrderLines)
            {
                order.AddProduct(item.ProductId, item.Count);
            }
            await _orderRepository.InsertAsync(order);
        }

        public Task<OrderDto> GetOrderDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
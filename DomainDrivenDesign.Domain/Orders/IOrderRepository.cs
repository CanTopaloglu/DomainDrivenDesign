namespace DomainDrivenDesign.Domain.Orders;

public interface IOrderRepository
{
    Task<Order> CreateAsync(CreateOrderDto request, CancellationToken cancellationToken = default);
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
}

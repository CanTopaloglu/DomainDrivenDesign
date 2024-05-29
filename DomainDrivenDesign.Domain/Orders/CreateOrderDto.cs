namespace DomainDrivenDesign.Domain.Orders;

public sealed record CreateOrderDto(
    string OrderNumber,
    int StatusValue,
    List<CreateOrderLineDto> OrderLines);

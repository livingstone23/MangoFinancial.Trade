using MediatR;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Commands;



/// <summary>
/// Is a class cant herit and is inmutable that permit to update an order
/// Here we definir the propertys that we need to update an order
/// </summary>
public sealed record UpdateOrderCommand: IRequest<bool>
{
    
    public int Id { get; set; }

    public int Quantity {get; set;}

    public OrderType Type {get; set;}

    public decimal Price {get; set;}

    public string? Text { get; set; }

}


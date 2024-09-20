using MediatR;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Commands;



/// <summary>
/// Class that represent the cancel order command
/// </summary>
public sealed record CancelOrderCommand: IRequest<bool>
{
    
    public int Id { get; set; }

}
using MediatR;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Queries;



/// <summary>
/// Class that permit to get an order query
/// </summary>
/// <value></value>
public sealed record GetOrderQuery: IRequest<GetOrderResponseDto>
{
    public int Id { get; set; }

}
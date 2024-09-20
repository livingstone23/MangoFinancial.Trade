using MediatR;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Queries.GetAllOrder;



/// <summary>
/// Class that permit to get all order query
/// </summary>
/// <value></value>
public sealed record GetAllOrderQuery: IRequest<IEnumerable<GetAllOrderResponseDto>>
{

}
using AutoMapper;
using MangoFinancial.Trade.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Queries.GetAllOrder;



/// <summary>
/// Class that permit to get all order query
/// </summary>
public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, IEnumerable<GetAllOrderResponseDto>>
{

    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllOrderHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<IEnumerable<GetAllOrderResponseDto>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
    
        var orders = await _context.Orders.ToListAsync(cancellationToken);

        var response = _mapper.Map<IEnumerable<GetAllOrderResponseDto>>(orders);

        return response;

    }
}
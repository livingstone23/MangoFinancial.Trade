using AutoMapper;
using MangoFinancial.Trade.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Queries;



/// <summary>
/// Class that permit to get an order query
/// </summary>
public class GetOrderHandler : IRequestHandler<GetOrderQuery, GetOrderResponseDto>
{

    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetOrderHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetOrderResponseDto> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);

        var response = _mapper.Map<GetOrderResponseDto>(order);

        return response;

    }
}
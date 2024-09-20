using AutoMapper;
using MangoFinancial.Trade.Domain.Entities;
using MangoFinancial.Trade.Interfaces.Persistence;
using MediatR;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Commands;



/// <summary>
/// Class that permit to create an order command
/// </summary>
public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
{

    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateOrderHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        
        var order = _mapper.Map<Order>(request);

        await _context.Orders.AddAsync(order, cancellationToken);

        if(await _context.SaveChangesAsync(cancellationToken)> 0)
            return true;
        else
            return false;
        
    }
}
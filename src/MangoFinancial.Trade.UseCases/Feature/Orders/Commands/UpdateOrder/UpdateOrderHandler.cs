using AutoMapper;
using MangoFinancial.Trade.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Commands;



/// <summary>
/// Class that permit to update an order command
/// </summary>
public class UpdateOrderHandler: IRequestHandler<UpdateOrderCommand, bool>
{

    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateOrderHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);

        if(order is not null)
        {
            order.Quantity = request.Quantity;
            order.Type = (Domain.Enums.OrderType)request.Type;
            order.Price = request.Price;
            order.Text = request.Text;

            if(await _context.SaveChangesAsync(cancellationToken)> 0)
                return true;
            else
                return false;

        }
            return false;
    }
}


using AutoMapper;
using MangoFinancial.Trade.Domain.Entities;
using MangoFinancial.Trade.UseCases.Feature.Orders.Commands;
using MangoFinancial.Trade.UseCases.Feature.Orders.Queries;

namespace MangoFinancial.Trade.UseCases.Commons.Mappings;

public class MappingsProfile: Profile
{
    public MappingsProfile()
    {
        CreateMap<CreateOrderCommand, Order>().ReverseMap();
        CreateMap<UpdateOrderCommand, Order>().ReverseMap();
        CreateMap<GetOrderResponseDto, Order>().ReverseMap();
        CreateMap<GetAllOrderResponseDto, Order>().ReverseMap();

    }
}
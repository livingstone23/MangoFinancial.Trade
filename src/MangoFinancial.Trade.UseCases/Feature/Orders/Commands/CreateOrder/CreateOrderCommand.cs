﻿using MediatR;



namespace MangoFinancial.Trade.UseCases.Feature.Orders.Commands;



/// <summary>
/// Class that represent the create order command
/// </summary>
public sealed record CreateOrderCommand: IRequest<bool>
{
    
    public int Id { get; set; }

    public string Symbol {get; set;}

    public OrderSide Side {get; set;}

    public DateTime TransactTime {get; set;}

    public int Quantity {get; set;}

    public OrderType Type {get; set;}

    public decimal Price {get; set;}

    public string Currency { get; set; }

    public string? Text { get; set; }


}

public enum OrderSide
{

    BUY = 0,
    SELL = 1

}

public enum OrderType
{

    LIMIT = 0,
    MARKET = 1
    
}
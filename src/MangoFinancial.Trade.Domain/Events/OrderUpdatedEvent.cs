using MangoFinancial.Trade.Domain.Commons;
using MangoFinancial.Trade.Domain.Enums;



namespace MangoFinancial.Trade.Domain.Events;



/// <summary>
/// Base class for register the event Order Updated event
/// </summary>
public class OrderUpdatedEvent: BaseEvent
{

    public string Id {get; set;}

    public int Quantity {get; set;}

    public OrderType Type {get; set;}

    public decimal Price {get; set;}

    public string? Text { get; set; }

}

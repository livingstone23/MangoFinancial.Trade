using MangoFinancial.Trade.Domain.Commons;
using MangoFinancial.Trade.Domain.Enums;



namespace MangoFinancial.Trade.Domain.Events;



/// <summary>
///  Base Class for register the event Order Created event
/// </summary>
public class OrderCreatedEvent: BaseEvent
{


    public int Id {get; set;}

    public string Symbol {get; set;}

    public OrderSide Side {get; set;}

    public DateTime TransactTime {get; set;}

    public int Quantity {get; set;}

    public OrderType Type {get; set;}

    public decimal Price {get; set;}

    public string Currency { get; set; }

    public string? Text { get; set; }


}

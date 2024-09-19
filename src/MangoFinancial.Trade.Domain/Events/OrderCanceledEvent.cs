using MangoFinancial.Trade.Domain.Commons;



namespace MangoFinancial.Trade.Domain.Events;



/// <summary>
/// Base class for register the event Order Canceled event
/// </summary>
public class OrderCanceledEvent: BaseEvent
{   

    public int Id {get; set;}

}

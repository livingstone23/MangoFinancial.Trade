namespace MangoFinancial.Trade.Domain.Commons;



/// <summary>
/// Base Class for all events
/// </summary>
public abstract class BaseEvent
{

    /// <summary>
    /// Identify the event
    /// </summary>
    /// <value></value>
    public Guid MessageId {get; set;}

    /// <summary>
    /// Identify the date and time of the event
    /// </summary>
    /// <value></value>
    public DateTime PublishTime {get; set;}

}

using MangoFinancial.Trade.Domain.Commons;
using MangoFinancial.Trade.Domain.Enums;



namespace MangoFinancial.Trade.Domain.Entities;



/// <summary>
/// Class that indicate the order entity
/// </summary>
public class Order: BaseAuditableEntity
{


    /// <summary>
    /// Indicate the name of the action to be performed
    /// </summary>
    /// <value></value>
    public string Symbol {get; set;}


    /// <summary>
    /// Indicate the side of the order
    /// </summary>
    /// <value></value>    
    public OrderSide Side {get; set;}


    /// <summary>
    /// Date and time of the transaction
    /// </summary>
    /// <value></value>
    public DateTime TransactTime {get; set;}


    /// <summary>
    /// Quantity of the order
    /// </summary>
    /// <value></value>
    public int Quantity {get; set;}


    /// <summary>
    /// Indicate the type of the order
    /// </summary>
    /// <value></value>
    public OrderType Type {get; set;}


    /// <summary>
    /// Indicate the price of the order
    /// </summary>
    /// <value></value>
    public decimal Price {get; set;}


    /// <summary>
    /// Indicate the currency of the order
    /// </summary>
    public string Currency { get; set; }


    /// <summary>
    /// Can contain any additional information about the order
    /// </summary>
    public string? Text { get; set; }

}

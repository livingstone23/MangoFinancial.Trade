namespace MangoFinancial.Trade.UseCases.Feature.Orders.Queries;



/// <summary>
/// Anwser object to the get order query
/// </summary>
public class GetOrderResponseDto
{
    public int Id { get; set; }

    public string Symbol {get; set;}

    public OrderSide Side {get; set;}

    public DateTime TransactTime {get; set;}

    public int Quantity {get; set;}

    public OrderType Type {get; set;}

    public decimal Price {get; set;}

    public string Currency { get; set; }

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

namespace MangoFinancial.Trade.UseCases.Feature.Orders.Queries;



public class GetAllOrderResponseDto
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
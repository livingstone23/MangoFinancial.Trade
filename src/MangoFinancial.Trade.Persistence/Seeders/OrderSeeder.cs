using MangoFinancial.Trade.Domain.Entities;
using MangoFinancial.Trade.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace MangoFinancial.Trade.Persistence.Seeders;



/// <summary>
/// Class that seed the database with the orders
/// </summary>
public class OrderSeeder: IEntityTypeConfiguration<Order>
{

    public void Configure(EntityTypeBuilder<Order> builder)
    {

        builder.HasData(
            new Order
            {
                Id = 1,
                Symbol = "META",
                Side = OrderSide.BUY,
                TransactTime = DateTime.UtcNow,
                Quantity = 1000,
                Type = OrderType.LIMIT,
                Price = 522.99M,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            },
            new Order
            {
                Id = 2,
                Symbol = "MSFT",
                Side = OrderSide.BUY,
                TransactTime = DateTime.UtcNow,
                Quantity = 300,
                Type = OrderType.MARKET,
                Price = 424.30M,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            },
            new Order
            {
                Id = 3,
                Symbol = "AMZN",
                Side = OrderSide.SELL,
                TransactTime = DateTime.UtcNow,
                Quantity = 400,
                Type = OrderType.MARKET,
                Price = 0,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            },
            new Order
            {
                Id = 4,
                Symbol = "TSLA",
                Side = OrderSide.SELL,
                TransactTime = DateTime.UtcNow,
                Quantity = 800,
                Type = OrderType.MARKET,
                Price = 0,
                Currency = "USD",
                Text = "",
                Created = DateTime.Now,
                CreatedBy = "system"
            }

        );


    }
}
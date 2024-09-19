using MangoFinancial.Trade.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace MangoFinancial.Trade.Persistence.Configurations;



/// <summary>
/// Class that indicate the configuration of the order entity for the database
/// </summary>
public class OrderConfiguration: IEntityTypeConfiguration<Order>
{

    public void Configure(EntityTypeBuilder<Order> builder)
    {

        builder.ToTable("Orders");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasPrecision(9,0)
            .IsRequired()
            .ValueGeneratedNever();

        builder.Property(x => x.Symbol)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Side)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(x=> x.TransactTime)
            .IsRequired();

        builder.Property(x => x.Quantity)
            .IsRequired()
            .HasPrecision(9,0);

        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(x => x.Price)
            .IsRequired()
            .HasPrecision(9, 4);

        builder.Property(x => x.Currency)
            .IsRequired()
            .HasMaxLength(3)
            .HasDefaultValue("USD");

        builder.Property(x => x.Text)
            .HasMaxLength(200)
            .IsRequired(false);

        builder.Property(x => x.Created)
            .IsRequired();

        builder.Property(x => x.CreatedBy)
            .HasMaxLength(120)
            .IsRequired();

        builder.Property(x => x.LastModified)
            .IsRequired(false);

        builder.Property(x => x.LastModifiedBy)
            .HasMaxLength(120)
            .IsRequired(false);
    }

}
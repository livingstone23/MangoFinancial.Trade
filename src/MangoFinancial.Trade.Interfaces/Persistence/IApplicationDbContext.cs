using MangoFinancial.Trade.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace MangoFinancial.Trade.Interfaces.Persistence;



/// <summary>
/// Interface that represent the database context
/// </summary>
public interface IApplicationDbContext
{

    DbSet<Order> Orders { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}
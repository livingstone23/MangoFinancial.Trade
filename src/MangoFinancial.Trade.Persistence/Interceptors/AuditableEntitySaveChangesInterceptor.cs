using MangoFinancial.Trade.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;



namespace MangoFinancial.Trade.Persistence.Interceptors;



/// <summary>
/// Class that intercepts the save changes of the database
/// Enable add audit information to the entities
/// </summary>
public class AuditableEntitySaveChangesInterceptor: SaveChangesInterceptor
{

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    public void UpdateEntities(DbContext? context)
    {
        if(context == null) return;

        foreach (var entry in context.ChangeTracker.Entries<BaseAuditableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedBy = "System";
                entry.Entity.Created = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.LastModifiedBy = "System";
                entry.Entity.LastModified = DateTime.UtcNow;
            }
        }
    }

}
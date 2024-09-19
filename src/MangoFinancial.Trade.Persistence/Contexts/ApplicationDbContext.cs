using MangoFinancial.Trade.Domain.Entities;
using MangoFinancial.Trade.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using System.Reflection;



namespace MangoFinancial.Trade.Persistence.Contexts;



/// <summary>
/// Class that represent the database context
/// </summary>
public class ApplicationDbContext: DbContext
{
    

    public readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor) : base(options)
    {
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
    }

    public DbSet<Order> Orders { get; set; }


    /// <summary>
    /// Method that configure the entities of the database
    /// </summary>
    /// <param name="builder"></param>
    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);

    }


    /// <summary>
    /// Method that configure the database context
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        optionsBuilder.EnableSensitiveDataLogging();

    }


    /// <summary>
    /// Method that save the changes of the database
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }


}
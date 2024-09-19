namespace MangoFinancial.Trade.Domain.Commons;



/// <summary>
/// Base Class for all entities, use this class if you want to add audit fields to your entity
/// </summary>
public abstract class BaseAuditableEntity: BaseEntity
{

    public DateTime Created  {get; set;}

    public string? CreatedBy {get; set;}

    public DateTime? LastModified {get; set;}

    public string? LastModifiedBy {get; set;}

}

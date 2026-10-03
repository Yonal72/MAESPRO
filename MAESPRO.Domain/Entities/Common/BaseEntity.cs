namespace MAESPRO.Domain.Entities.Common;

public abstract class BaseEntity
{
    // .NET 9 ile gelen zaman sıralı (sequential) Guid
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}
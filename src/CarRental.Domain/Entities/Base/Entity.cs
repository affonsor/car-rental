namespace CarRental.Domain.Entities.Base;
public abstract class Entity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
    public DateTime UpdatedAt { get; private set; }
    public bool AsDeleted { get; private set; }
    public void SetAsDeleted() => AsDeleted = true;
}
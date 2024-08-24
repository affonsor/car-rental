namespace CarRental.Domain.Entities;

public class Coupon(decimal value, IEnumerable<Guid> serviceId, IEnumerable<Service> services, DateOnly validDate) : Entity
{
    public IEnumerable<Guid> ServiceId { get; private set; } = serviceId;
    public IEnumerable<Service> Services { get; private set; } = services;
    public decimal Value = value;
    public Guid Code { get; private set; } = Guid.NewGuid();
    public DateOnly ValidDate { get; private set; } = validDate;
}
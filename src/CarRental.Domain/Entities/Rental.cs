namespace CarRental.Domain.Entities;
public class Rental(
    DateTime dateInit,
    DateTime dateEstimatedDelivery,
    DateTime dateDelivery,
    decimal totalCost,
    Guid categoryId,
    Category category,
    Guid vehicleId,
    Vehicle vehicle,
    Guid pickUpLocationId,
    Branch pickUpLocation,
    Guid dropOffLocationId,
    Branch dropOffLocation,
    string status,
    User userId,
    User user)
    : Entity
{
    public DateTime DateInit { get; private set; } = dateInit;
    public DateTime DateEstimatedDelivery { get; private set; } = dateEstimatedDelivery;
    public DateTime DateDelivery { get; private set; } = dateDelivery;
    public decimal TotalCost { get; private set; } = totalCost;
    public Guid CategoryId { get; private set; } = categoryId;
    public Category Category { get; private set; } = category;
    public Guid VehicleId { get; private set; } = vehicleId;
    public Vehicle Vehicle { get; private set; } = vehicle;
    public Guid PickUpLocationId { get; private set; } = pickUpLocationId;
    public Branch PickUpLocation { get; private set; } = pickUpLocation;
    public Guid DropOffLocationId { get; private set; } = dropOffLocationId;
    public Branch DropOffLocation { get; private set; } = dropOffLocation;
    public string Status { get; private set; } = status;
    public User UserId { get; private set; } = userId;
    public User User { get; private set; } = user;
}
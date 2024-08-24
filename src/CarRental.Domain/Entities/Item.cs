namespace CarRental.Domain.Entities;

public class Item(string name, string service, decimal price, string description, Guid rentalId, Rental rental)
    : Entity
{
    public string Name { get; private set; } = name;
    public string Service { get; private set; } = service;
    public decimal Price { get; private set; } = price;
    public string Description { get; private set; } = description;
    public Guid RentalId { get; private set; } = rentalId;
    public Rental Rental { get; private set; } = rental;
}
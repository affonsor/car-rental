namespace CarRental.Domain.Entities;
public class Vehicle(
    Guid modelId,
    Model model,
    Guid manufacturerId,
    Manufacturer manufacturer,
    long mileage,
    string? plate,
    string status,
    string chassi,
    string color,
    string motorNumber,
    string renavam) 
    : Entity
{
    public Guid ModelId { get; private set; } = modelId;
    public Model Model { get; private set; } = model;
    public Guid ManufacturerId { get; private set; } = manufacturerId;
    public Manufacturer Manufacturer { get; private set; } = manufacturer;
    public long Mileage { get; private set; } = mileage;
    public string? Plate { get; private set; } = plate;
    public string Status { get; private set; } = status;
    public string Chassi { get; private set; } = chassi;
    public string Color { get; private set; } = color;
    public string MotorNumber { get; private set; } = motorNumber;
    public string Renavam { get; private set; } = renavam;
}
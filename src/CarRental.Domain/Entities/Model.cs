namespace CarRental.Domain.Entities;
public class Model(
    string name,
    int year,
    Guid manufacturerId,
    Manufacturer manufacturer,
    Guid categoryId,
    Category category,
    string transmission,
    string motor,
    string type)
: Entity
{
    public string Name = name;
    public int Year = year;
    public Guid ManufacturerId { get; private set; } = manufacturerId;
    public Manufacturer Manufacturer { get; private set; } = manufacturer;
    public Guid CategoryId { get; private set; } = categoryId;
    public Category Category { get; private set; } = category;
    public string Transmission { get; private set; } = transmission;
    public string Motor { get; private set; } = motor;
    public string Type { get; private set; } = type;
}
namespace CarRental.Domain.Entities;
public class Manufacturer(string name) : Entity
{
    public string Name { get; private set; } = name;
}
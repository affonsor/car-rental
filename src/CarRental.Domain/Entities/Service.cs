namespace CarRental.Domain.Entities;

public class Service(string name, string description) : Entity
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
}
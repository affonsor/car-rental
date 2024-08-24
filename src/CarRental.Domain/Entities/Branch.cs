namespace CarRental.Domain.Entities;
public class Branch(string name, Address address) : Entity
{
    public string Name { get; private set; } = name;
    public Address Address { get; private set; } = address;
}
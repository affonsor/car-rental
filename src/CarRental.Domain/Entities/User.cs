namespace CarRental.Domain.Entities;

public class User(string name, DateOnly birthDate, string phone, Email email, Documents documents)
    : Entity
{
    public string Name { get; private set; } = name;
    public DateOnly BirthDate{ get; private set; } = birthDate;
    public string Phone{ get; private set; } = phone;
    public Email Email{ get; private set; } = email;
    public Documents Documents{ get; private set; } = documents;
}
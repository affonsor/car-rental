using CarRental.Domain.ValueObjects.Base;

namespace CarRental.Domain.ValueObjects;

public class Address(
    string street,
    string number,
    string complement,
    string neighborhood,
    string city,
    string state,
    string postalCode,
    string country)
    : ValueObject
{
    public string Street { get; } = street;
    public string Number { get; } = number;
    public string Complement { get; } = complement;
    public string Neighborhood { get; } = neighborhood;
    public string City { get; } = city;
    public string State { get; } = state;
    public string PostalCode { get; } = postalCode;
    public string Country { get; } = country;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
    }
}
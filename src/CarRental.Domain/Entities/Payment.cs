namespace CarRental.Domain.Entities;

public class Payment(Guid rentalId, Rental rental, DateTime date, string method, decimal value, string status)
    : Entity
{
    public Guid RentalId { get; private set; } = rentalId;
    public Rental Rental { get; private set; } = rental;
    public DateTime Date { get; private set; } = date;
    public string Method { get; private set; } = method;
    public decimal Value { get; private set; } = value;
    public string Status { get; private set; } = status;
}
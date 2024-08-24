using System.Text.RegularExpressions;
using CarRental.Domain.ValueObjects.Base;

namespace CarRental.Domain.ValueObjects;

public partial class Email : ValueObject
{
    private const string Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    private const string InvalidEmailMessage = "Invalid email address";

    public Email(string address)
    {
        if (string.IsNullOrEmpty(address))
            throw new Exception(InvalidEmailMessage);

        Address = address.Trim().ToLower();

        if (Address.Length < 5)
            throw new Exception(InvalidEmailMessage);

        if (!EmailRegex().IsMatch(Address))
            throw new Exception(InvalidEmailMessage);

    }
    private string Address { get; }
    public static implicit operator string(Email email) => email.ToString();
    public static implicit operator Email(string address) => new Email(address);
    [GeneratedRegex(Pattern)]
    private static partial Regex EmailRegex();
    public override string ToString() => Address;
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Address;
    }
}
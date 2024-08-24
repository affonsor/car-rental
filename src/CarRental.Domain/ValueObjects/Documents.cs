using System.Text.RegularExpressions;
using CarRental.Domain.ValueObjects.Base;

namespace CarRental.Domain.ValueObjects;

public partial class Documents : ValueObject
{
    private const string Pattern = @"^\d{11}$";

    public Documents(string cpf, string? cnh)
    {
        if (!DocumentsRegex().IsMatch(cpf))
            throw new Exception("Invalid CPF!");
        if (!string.IsNullOrEmpty(cnh) && !DocumentsRegex().IsMatch(cnh))
            throw new Exception("Invalid Cnh!");
        
        Cpf = cpf;
        Cnh = cnh;
    }
    public string Cpf { get; private set; }
    public string? Cnh { get; private set; }
    [GeneratedRegex(Pattern)]
    private static partial Regex DocumentsRegex(); 
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Cpf;
        yield return Cnh ?? string.Empty;
    }
}
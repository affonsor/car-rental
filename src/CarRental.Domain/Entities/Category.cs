namespace CarRental.Domain.Entities;
public class Category(string name, decimal dailyValue) : Entity
{
    public string Name = name;
    public decimal DailyValue = dailyValue;
}
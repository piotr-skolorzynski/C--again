using StructImprovements;

var money = new Money()
{
    Value = 10,
    Currency = "$"
};
var money2 = money with { Value = 20 };

var someValue = new DerivedRecord("a", "b");

Console.WriteLine(someValue);

public record class DerivedRecord(string Value, string BaseValue) : BaseRecord(BaseValue);

public record class BaseRecord(string BaseValue)
{
    public sealed override string ToString()
    {
        return "Base implementation";
    }
};

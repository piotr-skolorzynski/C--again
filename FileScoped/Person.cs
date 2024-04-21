namespace FileScoped;
public class Person
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }

    public int CalculateSalary()
    {
        var newCalculator = new Calculator();
        return newCalculator.Calculate(this);
    }
}

// klasa o zasięgu lokalnym, używamy słowa kluczowego file
file class Calculator 
{
    public int Calculate(Person person)
    {
        return 100;
    }
}

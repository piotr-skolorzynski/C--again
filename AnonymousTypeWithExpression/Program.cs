var someValue = new 
{
    Value = 10,
    Name = "test"
};

Console.WriteLine(someValue);

// można wykonać kopię z operatorem with

var someValue2 = someValue with { Name = "mleko", Value = 30 };

Console.WriteLine(someValue2);
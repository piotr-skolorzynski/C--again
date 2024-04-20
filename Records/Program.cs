// var currency1 = new CurrencyRecord()
// {
//     Name = "USD",
//     Value = 10
// };

// var currency2 = new CurrencyRecord()
// {
//     Name = "USD",
//     Value = 10
// };

var currency3 = new CurrencyClass("USD", 10);

//chcemy zapobiec możliwości nadpisania
// currency3.Value = 20;

var currency1 = new CurrencyRecord("USD", 10, "SomeValue");
var currency2 = new CurrencyRecord("USD", 10, "SomeValue");

//klonowanie obiektu z zerwaniem referencji
var currency4 = currency1 with {};
//klonowanie obiektu z zerwaniem referencji i zmianą wartości wybranych pól
var currency5 = currency1 with { Value = 50 };

// w podstawowym sposobie wartości możemy pobrać następująco:
// var name = currency5.Name;
// var value = currency5.Value;

//nazwy zmiennych muszą odpowiadać nazwom z publicznego konstruktora
var (name, value, _) = currency5;

Console.WriteLine(name);
Console.WriteLine(value);

public abstract record BaseCurrencyRecord(string SomeValue);

//dziedziczenie rekordu z rekordu
public record CurrencyRecord(string Name, decimal Value, string SomeValue): BaseCurrencyRecord(SomeValue), IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }    
}

//implementacja interfejsu
// public record CurrencyRecord(string Name, decimal Value): IDisposable
// {
//     public void Dispose()
//     {
//         throw new NotImplementedException();
//     }
// }

// Console.WriteLine(currency1);
// Console.WriteLine(currency2);
// Console.WriteLine($"currency1 == currency2 : {currency1 == currency2}");
// Console.WriteLine($"object.ReferenceEquals(currency1, currency2) : {object.ReferenceEquals(currency1, currency2)}");
public record CurrencyClass
{
    public string Name { get; }
    public decimal Value { get;}

    public CurrencyClass(string name, decimal value)
    {
        Name = name;
        Value = value;
    }
}

// record z publicznym konstruktorem zapobiegającym nadpisaniu wartości w obiektach

// public record CurrencyRecord
// {
//     public string Name { get; set; }
//     public decimal Value { get; set; }
// }

//typy generyczne dla rekordów
public record CurrencyRecord<T>(string Name, decimal Value, string SomeValue)
    : BaseCurrencyRecord(SomeValue), IDisposable
    //where T : record - póki co nie ma jeszcze możliwości ograniczenia typów generycznych tylko do rekordów
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }    
}


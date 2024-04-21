//dotychczas tylko w rekordach można było definiować konstruktory niejawnie
// var person = new Person("Pioter", "Skołek");
// record Person(string FirstName, string LastName);

//od wersji .net8.0 można to robić również dla innych typów
class Person(string firstName, string lastName)
{
    //każdy jawnie deklarowany konstruktor musi się odnieść do tego niejawnego
    //nawet pusty
    public Person(): this("", "")
    {

    }
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;

    public void SayHi()
    {
        Console.WriteLine($"Hi, I am {firstName} {lastName}");
    }

    // co więcej pod parametry z konstruktora mogę nadpisać inną wartość
}

public interface IService
{
    object GetData();
}

public class ExampleController(IService service) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetData());
    }
}
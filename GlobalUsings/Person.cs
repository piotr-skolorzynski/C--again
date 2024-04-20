namespace GlobalUsings.Person;
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

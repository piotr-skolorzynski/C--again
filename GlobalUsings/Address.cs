namespace GlobalUsings.Address;
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string MyProperty { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

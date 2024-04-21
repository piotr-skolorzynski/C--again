namespace GenericAttributes;

public class EqualsAttribute<T>: Attribute
{
    public EqualsAttribute(T value)
    {
        Value = value;
    }
    public T Value{ get; set; }
}
public class Person
{
    [EqualsAttribute<string>("Piotr")]
    public string Name { get; set; } = default!;
    [EqualsAttribute<int>(10)]
    public int Score { get; set; }
}

namespace Reflection;

public class Person
{
    //nakładanie atrybutu na klasie (nie musimy pisać słówka Attribute bo jest domyślnie dopisywana)
    [DisplayProperty("First Name")]
    public string FirstName { get; set; }

    //jest możliwe użycie więcej atrybutów jeśli flaga AllowMultiple jest na true
    [DisplayProperty("Last Name")]
    [DisplayProperty("Last Name1")]
    public string LastName { get; set; }
    public Address Address { get; set; }
}

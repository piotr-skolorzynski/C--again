namespace Reflection;

//Atrybut na atrybucie umożliwiający określenie ograniczenia jego użycia
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class DisplayPropertyAttribute: Attribute
{
    public string DisplayName { get; set; }  

    //właściwość przekazujemy poprzez konstruktor
    public DisplayPropertyAttribute(string displayName)
    {
        DisplayName = displayName;  
    }
}

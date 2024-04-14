using System.Reflection;
using Reflection;

namespace FirstProject
{
  internal class Program
  {
    static void Display(Object obj)
    {   
        Type objType = obj.GetType();
        var properties = objType.GetProperties();
        foreach (var property in properties)
        {
           var propValue = property.GetValue(obj);
           var propType = propValue.GetType();
           if (propType.IsPrimitive || propType == typeof(string))
           {
            var displayPropertyAttribute = property.GetCustomAttribute<DisplayPropertyAttribute>();
            if (displayPropertyAttribute != null)
            {
                Console.WriteLine($"{displayPropertyAttribute.DisplayName}: {propValue}");
            }
            else 
            {
                Console.WriteLine($"{property.Name}: {propValue}");
            }
           }
        }
    }
    static void Main(string[] args)
    {
        Address address = new Address(){
            City = "Krakow",
            Street = "Grodzka 5",
            PostalCode = "31-556"
        };
        Person person = new Person()
        {
            FirstName = "John",
            LastName = "Doe",
            Address = address
        };
        Console.WriteLine("Person");
        Display(person);
        
        Console.WriteLine("Insert person property to update");
        var propertyToUpdate = Console.ReadLine();

        Console.WriteLine("Insert value to update");
        var valueToUpdate = Console.ReadLine();
        SetValue(person, propertyToUpdate, valueToUpdate);
        Console.WriteLine("Person:");
        Display(person);
    }
    static void SetValue<T>(T obj, string propName, string value)
    {
        Type objType = typeof(T);
        var propertyToUpdate = objType.GetProperty(propName);
        if (propertyToUpdate != null)
        {
            //ustawianie nowej wartości na propce podanej przez użytkownika
            propertyToUpdate.SetValue(obj, value);
        }
    }
  }
}

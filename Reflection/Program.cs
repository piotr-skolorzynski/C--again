using System.Reflection;
using Reflection;

namespace FirstProject
{
  internal class Program
  {

    static void Display(Object obj)
    {   
        // metodę można wywołać na każdym obiekcie by poznać jego typ
        Type objType = obj.GetType();
        //pobranie właściwości typu w postaci kolekcji
        var properties = objType.GetProperties();
        foreach (var property in properties)
        {
           // dla każdej propki możemy pobrać jej wartość
           var propValue = property.GetValue(obj);
           //pobieramy sobie typ danej property żeby sprawdzić czy jest referencja do innego typu
           // jeśli tak to nie będziemy chcieli jej wyświetlać
           var propType = propValue.GetType();
           if (propType.IsPrimitive || propType == typeof(string))
           {
            //po tym jak nadaliśmu customowe atrybuty w klasie Person możemy sprawdzić czy taki 
            //istnieje jeśli tak to chcemy go wyświetlić zamiast pierowtnego
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
        Console.WriteLine("address");
        Display(address); 
    }
  }
}

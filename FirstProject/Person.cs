using System;

namespace FirstProject;
public class Person
{
    public string FirstName;
    public string LasName;
    private DateTime dateOfBirth;
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LasName = lastName;
        Console.WriteLine("Constructor1");
    }
    //żeby nie powielać kodu w kolejnym konstruktorze stosuje się zapis po nawiasie z parametrami
    public Person(DateTime dateOfBirth, string firstName, string lastName): this(firstName, lastName)
    {
        SetDateOfBirth(dateOfBirth);
        Console.WriteLine("Constructor2");
    }
    //Poniżej setter i getter dla prywatnego pola dateOfBirth
    public void SetDateOfBirth(DateTime date)
    {
        if (dateOfBirth > DateTime.Now)
        {
            Console.WriteLine("Invalid date of birth");
        }
        else
        {
            dateOfBirth = date;
        }
    } 
    // public DateTime getDateOfBirth() 
    // {
    //     return dateOfBirth;
    // }
    /* od wersji c# ver 6 dla powyżeszej metody wprowadzono coś takiego jak
       expression value */
    public DateTime GetDateOfBirth() => dateOfBirth;
    public void SayHi()
    {
        Console.WriteLine($"Hi, I am {FirstName}, {GetDateOfBirth()}");
    }
}

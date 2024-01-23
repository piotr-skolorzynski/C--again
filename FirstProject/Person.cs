using System;

namespace FirstProject;
public class Person
{
    public string FirstName;
    public string LasName;
    public static int Count = 0;
    private DateTime dateOfBirth;
    private string contactNumber;

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set 
        {
            if (dateOfBirth > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateOfBirth = value;
            }
        }
    }

    public string ContactNumber
    {
        get { return contactNumber; }
        set 
        { 
            if (value.Length < 9)
            {
                Console.WriteLine("Invalid contact number");
            } 
            else 
            {
                contactNumber = value;
            }
        
        }
    }

    //Jeśli właściwość nie ma złożonej logiki zapisu i odczytu to jej deklarację można uprościć
    // public string ContactNumber {get; set;}
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LasName = lastName;
        Count++;
        Console.WriteLine("Constructor1");
    }
    //żeby nie powielać kodu w kolejnym konstruktorze stosuje się zapis po nawiasie z parametrami
    public Person(DateTime dateOfBirth, string firstName, string lastName): this(firstName, lastName)
    {
        DateOfBirth = dateOfBirth;
        Console.WriteLine("Constructor2");
    }
    public void SayHi()
    {
        Console.WriteLine($"Hi, I am {FirstName}, {DateOfBirth}");
    }
}

using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("x - End program");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while(true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please insert name: ");
                        var contactName = Console.ReadLine();
                        Console.WriteLine("Please insert number: ");
                        var contactNumber = Console.ReadLine();
                        var contact = new Contact(contactName, contactNumber);
                        phoneBook.AddContact(contact);
                        break;
                    case "2":
                        Console.WriteLine("Please insert number: ");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Please insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}

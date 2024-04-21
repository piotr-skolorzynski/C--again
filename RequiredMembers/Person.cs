namespace RequiredMembers;
public class Person
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
}

// public class Person
// {
//     public Person(string firstName, string lastName)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//     }

//     public Person(string firstName, string lastName, string middleName): this(firstName, lastName)
//     {
//         MiddleName = middleName;
//     }

//     public string FirstName { get; set; }
//     public string? MiddleName { get; set; }
//     public string LastName { get; set; }
// }

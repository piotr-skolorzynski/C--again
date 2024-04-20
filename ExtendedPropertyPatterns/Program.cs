
var person = new Person()
{
    Name = "Person",
    Address = new Address() 
    { 
        City = "TestCity",
        Street = "TestStreet",
        HouseNumber = 10
    }
};

// var locationInfo = person switch
// {
//     { Address: { City: "TestCity"} } and { Address: { HouseNumber: < 10 } } => "Test city below 10",
//     { Address: { City: "TestCity"} } and { Address: { HouseNumber: >= 10 } } => "Test city at least 10",
//     _ => "no info"
    
// };

// nowa składnia
var locationInfo = person switch
{
    { Address.City: "TestCity" } and { Address.HouseNumber: < 10 } => "Test city below 10",
    { Address.City: "TestCity" } and { Address.HouseNumber: >= 10 } => "Test city at least 10",
    _ => "no info"
    
};

internal class Person 
{
    public string Name { get; set; }
    public Address Address { get; set; }
}

internal class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public int HouseNumber { get; set; }
}

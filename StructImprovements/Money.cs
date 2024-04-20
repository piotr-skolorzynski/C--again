namespace StructImprovements;
// public struct Money
// {
//     public Money()
//     {
//         Currency = "";
//         Value = 0;
//     }
//     public string Currency { get; set; }
//     public decimal Value { get; set; }
// }

// rekord który może być strukturą
public record struct Money(string Currency, decimal Value);

// rekord jako klasa - ale to jest to samo co public record Money2
public record class Money2(string Currency, decimal Value);

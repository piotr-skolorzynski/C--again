var parse = (string s) => int.Parse(s); //C#10(.net6.0)

Func<string, int> parse2 = (s) => int.Parse(s); //C#9(.net5.0)

var read = Console.Read; //Just one overload; Func<int> inferred
var write = Console.WriteLine; //Error: Miltiple overloads, can't choose

var result = object (bool b) => b ? 1 : "0"; // lambda return type

var someLambda = [Obsolete](string s) => parse(s); //lambda attributes
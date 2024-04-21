// string filename1 = "c:\\docume\"nts\\fi" + 
//     "les\\file" + 
//     "name.txt";
// string filename2 = @"c:\\docume""nts\\fil
//     es\\file
//     name.txt";
// //nowy sposób w .net7.0
// string filename3 = """
// c:\\
// docume""nts\\
// files\\
// filename.txt
// """;

// var folder = "mleko";

// string filename4 = $""""c:\\docume"""nts\\{folder}\\filename.txt"""";

// Console.WriteLine(filename1);
// Console.WriteLine(filename2);
// Console.WriteLine(filename3);
// Console.WriteLine(filename4);

using System.Text;

var rating = 3;
var message = $"This course has rating of {rating}, which means it {rating switch
    {
        < 3 => "sucks",
        _ => "not bad" 
    }}";

Console.WriteLine(message);

//poprzednio
var oldEncoding  = Encoding.UTF8.GetBytes("Some value");

var newEncoding = "Some value"u8.ToArray(); //obecnie można użyć u8 tylko na stringach zahardcodowanych w kodzie

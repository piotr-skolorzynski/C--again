using System;
using System.Text;

namespace FirstProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int result;
            int x = 10;
            int y = 5;

            //Kolejność działań matematycznych jest zachowana 
            int value = 2 + 2 * 5; //12
            Console.WriteLine("kolejność działań zachowana dla przykładu 2 + 2 * 5 = " + value);

            result = (x + y);
            Console.WriteLine("Additional Operator: x + y = " + result);

            result = (x - y);
            Console.WriteLine("Substraction Operator: x - y = " + result);

            result = (x * y);
            Console.WriteLine("Multiplication Operator: x * y = " + result);

            result = (x / y);
            Console.WriteLine("Division Operator: x / y = " + result);

            result = (x % y);
            Console.WriteLine("Modulo Operator: x % y = " + result);

            int value1 = 10;
            int value2 = 10;

            Console.WriteLine("Pre-increment result:");
            Console.WriteLine(++value1);

            Console.WriteLine("Post-increment result:");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);

            bool boolResult;
            x = 2;
            y = 10;

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);

            boolResult = (x == y);
            Console.WriteLine("Equal to Operator: (x == y) = " + boolResult);

            boolResult = (x > y);
            Console.WriteLine("Greater than Operator: (x > y) = " + boolResult);

            boolResult = (x < y);
            Console.WriteLine("Less than Operator: (x == y) = " + boolResult);

            boolResult = (x >= y);
            Console.WriteLine("Greater than or Equal to Operator: (x >= y) = " + boolResult);

            boolResult = (x <= y);
            Console.WriteLine("Less than or Equal to Operator: (x <= y) = " + boolResult);

            boolResult = (x != y);
            Console.WriteLine("Not Equal to Operator: (x == y) = " + boolResult);

            bool a = true;
            bool b = false;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            
            boolResult = a && b;
            Console.WriteLine("AND Operator: (a && b) = " + boolResult);

            boolResult = (a || b);
            Console.WriteLine("OR Operator: (a || b) = " + boolResult);

            boolResult = (!a);
            Console.WriteLine("NOT Operator: !a = " + boolResult);
            
            
            int greaterNumber = x > y ? x : y;
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " + greaterNumber);
            
            
            Console.ReadLine();
        }
    }
}

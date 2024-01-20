using System;
using System.Text;

namespace FirstProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string message1;
            message1 = "some value";

            string message2 = null;

            string message3 = string.Empty; //reprezentuje wartość brak znaków
            // string.Empty != null

            string text = "He sadi \"Hi\"";
            //znak \ przed cudzysłowiem oznacza że chcemy żeby wyświetlono cudzysłów a nie żeby
            // kompilator traktował go jako znak specjlany

            string widowLocation = "c:\\windows";
            //powyżej tak samo jesli chcemy żeby był wyświetlony znak \ to przed nim umieszczono
            // \ jako znak specjalny

            //powyższy zapid jest upierdliwy więc stworzono stringi dosowe tzw verbatim string
            string fontsFolder = @"c:\windows\fonts";
            // jedynym wyjątkiem jest cudzysłów, dla niego nawet verbatim nie pomoże

            //konkatenacja
            //wykorzystanie metody concat, można dodać więcej argumentów, należy oddzielać je przecinkami
            string concatenated = string.Concat(text, " to me");

            // można to też robić poprzez używanie operatora +
            string concatenated2 = text + " to " + "me";

            //interpolacja stringów (coś podobnego do template string)
            string interpolated  = $"{text} to me";
            //należy jednak pamiętać że interpolowany string zajmuje nowe miejsce w pamięci więc wielokrotne interpolowanie 
            // tworzy nowe zmienne i pożera pamięć.

            //dlatego wymyślono string buildera żeby dynamicznie powiększał wartość dla zmiennej a nie tworzył nowej
            StringBuilder sb = new StringBuilder("This"); // teraz można powiększać stringa
            sb.Append(" is");
            sb.Append(" a");
            sb.Append(" long");
            sb.Append(" text");

            string result = sb.ToString();
            Console.WriteLine("String builder result: " + result);

            Console.ReadLine();
        }
    }
}

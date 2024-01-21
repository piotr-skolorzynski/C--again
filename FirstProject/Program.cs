using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                Jeżeli mamy sytuację że wyświetlamy jakąś wartość a może być że jeszcze ona nie została 
                zadeklarowana to otrzymamy błąd. więc można zastosować np. flagę i ternary operator

                int favoriteNumber = 23;
                bool favoriteNumberHasValue = false;

                Console.WriteLine("Favorite number: " + (favoriteNumberHasValue ? favoriteNumber.ToString() : ""));

                Żeby uniknąć takiego rozwlekłego kodu wymyślono nullable
                można taką zmienną deklarować jako Nullable<int> lub krócej int?
            */

            int? favoriteNumber = 23;
            // Console.WriteLine("Favorite number: " + (favoriteNumber != null ? favoriteNumber.ToString() : ""));
            // lub
            Console.WriteLine("Favorite number: " + (favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : ""));
        }
    }
}

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za duzo aza mało");

            // 1. Komputer losuje
            Random los = new Random(); // tworzę obiekt typu Random
            int wylosowana = los.Next(1, 101);
            Console.WriteLine(wylosowana);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100.\nOdgadnij ją!");

            // 2. Człowiek proponuje
            Console.Write("Podaj swoją propozycję: ");
            int propozycja = int.Parse( Console.ReadLine() );

            // 3. Komputer ocenia
            if( propozycja < wylosowana )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Za mało");
                Console.ResetColor();
            }
            else if( propozycja > wylosowana )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Za dużo");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Trafiono");
                Console.ResetColor();
            }

        }
    }
}

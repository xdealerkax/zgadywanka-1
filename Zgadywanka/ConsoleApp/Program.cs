﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za duzo za mało");

            // 1. Komputer losuje
            #region losowanie
            var los = new Random(); // tworzę obiekt typu Random
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif
            Console.WriteLine("Wylosowałem liczbę od 1 do 100.\nOdgadnij ją!");
            #endregion

            bool odgadniete = false;
            // dopóki nie odgadnięte
            while ( !odgadniete )
            {
                // 2. Człowiek proponuje
                Console.Write("Podaj swoją propozycję: ");
                int propozycja = int.Parse(Console.ReadLine());

                // 3. Komputer ocenia
                if (propozycja < wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za mało");
                    Console.ResetColor();
                }
                else if (propozycja > wylosowana)
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
                    odgadniete = true;
                }
            }

            Console.WriteLine("Koniec gry");
        }
    }
}

using System;

namespace T3Z2
{
    class Program
    {
        private static Random rnd = new Random();
        private static int count = 0;
        private static bool isFound = false;
        static void Main(string[] args)
        {
            int drawnNumber = rnd.Next(0, 101);

            while(!isFound)
            {
                Console.Write("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    count++;
                    if (number == drawnNumber)
                    {
                        Console.WriteLine($"Odgadłeś wylosowaną liczbę w {count} próbach");
                        isFound = true;
                    }
                    else if (number > drawnNumber)
                        Console.WriteLine("Podana liczba jest większa od wylosowanej");
                    else
                        Console.WriteLine("Podana liczba jest mniejsza od wylosowanej");
                }
            }
        }
    }
}

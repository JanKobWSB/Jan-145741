using System;

namespace RysowanieTrojkata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość trójkąta:");
            int wysokosc = Convert.ToInt32(Console.ReadLine());

            int szerokosc = wysokosc * 2 - 1;

            for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
            {
                int iloscZnakow = wiersz * 2 - 1;
                int iloscSpacji = (szerokosc - iloscZnakow) / 2;

                for (int i = 0; i < iloscSpacji; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < iloscZnakow; i++)
                {
                    Console.Write("+");
                }

                Console.WriteLine();
            }
        }
    }
}

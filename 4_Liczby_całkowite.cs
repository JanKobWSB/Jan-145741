using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę c:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę d:");
        int d = Convert.ToInt32(Console.ReadLine());

        int x, y;

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            x = a * d + b * c;
            y = b * d;
            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }
    }
}

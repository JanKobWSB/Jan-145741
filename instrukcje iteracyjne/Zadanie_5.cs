using System;

class Program
{
    static void Main()
    {
        int x, n;

        do
        {
            Console.Write("Podaj liczbę naturalną x: ");
        } while (!int.TryParse(Console.ReadLine(), out x) || x < 0);

        do
        {
            Console.Write("Podaj liczbę całkowitą nieujemną n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

        long result = Power(x, n);
        long expected = (long)Math.Pow(x, n);

        Console.WriteLine("\nWynik otrzymany algorytmem: " + result);
        Console.WriteLine("Wynik prawidłowy: " + expected);

        if (result == expected)
        {
            Console.WriteLine("Wyniki są zgodne.");
        }
        else
        {
            Console.WriteLine("Wyniki nie są zgodne.");
        }

        Console.ReadLine();
    }

    static long Power(int x, int n)
    {
        long result = x;

        for (int i = 1; i < n; i++)
        {
            long temp = result;
            for (int j = 1; j < x; j++)
            {
                result += temp;
            }
        }

        return result;
    }
}

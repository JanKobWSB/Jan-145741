using System;

public class Program
{
    public static int CalculateFactorial(int number)
    {
        int result = 1;

        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int x, n;

        Console.WriteLine("Podaj liczbę x:");
        x = Convert.ToInt32(Console.ReadLine());

        n = 0;
        int factorial = CalculateFactorial(n);

        while (factorial <= x)
        {
            if (factorial == x)
            {
                Console.WriteLine("Liczba " + x + " jest silnią liczby " + n);
                return;
            }

            n++;
            factorial = CalculateFactorial(n);
        }

        Console.WriteLine("Liczba " + x + " nie jest silnią żadnej liczby");
    }
}
using System;

public class Program
{
    public static int Power(int baseNumber, int exponent)
    {
        int result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę podstawy: ");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wykładnika: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = Power(baseNumber, exponent);

        Console.WriteLine("Wynik potęgowania: " + result);
    }
}
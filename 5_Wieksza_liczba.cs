using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        int wiekszaLiczba = Math.Max(liczba1, liczba2);

        Console.WriteLine("Większa liczba: " + wiekszaLiczba);
    }
}
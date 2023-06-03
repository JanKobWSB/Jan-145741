using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj długość pierwszego boku:");
        double bok1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość drugiego boku:");
        double bok2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość trzeciego boku:");
        double bok3 = Convert.ToDouble(Console.ReadLine());

        if (CzyTrojkatRownoboczny(bok1, bok2, bok3))
        {
            Console.WriteLine("Podane boki mogą utworzyć trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie mogą utworzyć trójkąta równobocznego.");
        }
    }

    static bool CzyTrojkatRownoboczny(double bok1, double bok2, double bok3)
    {
        return (bok1 == bok2 && bok2 == bok3);
    }
}
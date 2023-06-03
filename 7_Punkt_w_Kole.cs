using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędną x punktu P:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędną y punktu P:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj promień koła:");
        double r = Convert.ToDouble(Console.ReadLine());

        if (CzyPunktWewnatrzKola(x, y, r))
        {
            Console.WriteLine("Punkt P({0}, {1}) leży wewnątrz koła.", x, y);
        }
        else
        {
            Console.WriteLine("Punkt P({0}, {1}) nie leży wewnątrz koła.", x, y);
        }
    }

    static bool CzyPunktWewnatrzKola(double x, double y, double r)
    {
        double odlegloscOdSrodka = Math.Sqrt(x * x + y * y);
        return odlegloscOdSrodka <= r;
    }
}
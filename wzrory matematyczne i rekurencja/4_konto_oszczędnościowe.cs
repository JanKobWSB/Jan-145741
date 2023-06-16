using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj kwotę początkową na koncie oszczędnościowym:");
        double kwotaPoczątkowa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
        double oprocentowanie = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
        int LiczbaMiesięcy = Convert.ToInt32(Console.ReadLine());

        double miesięcznaStopaProcentowa = oprocentowanie / 12 / 100;
        double zarobioneOdsetki = kwotaPoczątkowa * Math.Pow((1 + miesięcznaStopaProcentowa), LiczbaMiesięcy) - kwotaPoczątkowa;
        double kwotaKońcowa = kwotaPoczątkowa + zarobioneOdsetki;


        Console.WriteLine("Końcowa kwota oszczędności po uwzględnieniu podatku Belki: " + kwotaKońcowa);
    }
}

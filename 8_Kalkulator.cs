using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz działanie:");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        int numerDzialania = Convert.ToInt32(Console.ReadLine());

        double wynik;

        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                Console.WriteLine("Wynik dodawania: " + wynik);
                break;
            case 2:
                wynik = liczba1 - liczba2;
                Console.WriteLine("Wynik odejmowania: " + wynik);
                break;
            case 3:
                wynik = liczba1 * liczba2;
                Console.WriteLine("Wynik mnożenia: " + wynik);
                break;
            case 4:
                if (liczba2 == 0)
                {
                    Console.WriteLine("Wynik dzielenia: " + liczba1 + "/0");
                }
                else
                {
                    wynik = liczba1 / liczba2;
                    Console.WriteLine("Wynik dzielenia: " + wynik);
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania.");
                break;
        }
    }
}
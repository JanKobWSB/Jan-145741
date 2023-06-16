using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");

        int min = 1;
        int max = 20;
        int guess;
        string userResponse;

        while (true)
        {
            guess = (min + max) / 2;

            Console.WriteLine("Czy Twoja liczba to " + guess + "?");
            Console.WriteLine("Odpowiedz '-' jeśli Twoja liczba jest mniejsza,");
            Console.WriteLine("odpowiedz '+' jeśli Twoja liczba jest większa,");
            Console.WriteLine("lub odpowiedz '0' jeśli odgadłem liczbę.");

            userResponse = Console.ReadLine();

            if (userResponse == "0")
            {
                Console.WriteLine("Brawo! Odgadłem liczbę.");
                break;
            }
            else if (userResponse == "+")
            {
                min = guess + 1;
            }
            else if (userResponse == "-")
            {
                max = guess - 1;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Spróbuj ponownie.");
            }
        }
    }
}

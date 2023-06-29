using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = 0;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out rozmiar) && rozmiar > 0 && rozmiar % 2 == 0)
                break;
            else
                Console.Write("Niepoprawny rozmiar. Podaj liczbę parzystą większą od zera: ");
        }

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
            else
            {
                for (int j = rozmiar - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

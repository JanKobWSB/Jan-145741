using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = 0;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out rozmiar) && rozmiar > 0)
                break;
            else
                Console.Write("Niepoprawny rozmiar. Podaj liczbę większą od zera: ");
        }

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;
        int dolnyWiersz = 0;
        int gornyWiersz = rozmiar - 1;
        int lewaKolumna = 0;
        int prawaKolumna = rozmiar - 1;

        while (true)
        {
            // Wypełnianie górnego wiersza (od lewej do prawej)
            for (int j = lewaKolumna; j <= prawaKolumna; j++)
            {
                tablica[dolnyWiersz, j] = liczba;
                liczba++;
            }
            dolnyWiersz++;

            if (liczba > rozmiar * rozmiar)
                break;

            // Wypełnianie prawej kolumny (od góry do dołu)
            for (int i = dolnyWiersz; i <= gornyWiersz; i++)
            {
                tablica[i, prawaKolumna] = liczba;
                liczba++;
            }
            prawaKolumna--;

            if (liczba > rozmiar * rozmiar)
                break;

            // Wypełnianie dolnego wiersza (od prawej do lewej)
            for (int j = prawaKolumna; j >= lewaKolumna; j--)
            {
                tablica[gornyWiersz, j] = liczba;
                liczba++;
            }
            gornyWiersz--;

            if (liczba > rozmiar * rozmiar)
                break;

            // Wypełnianie lewej kolumny (od dołu do góry)
            for (int i = gornyWiersz; i >= dolnyWiersz; i--)
            {
                tablica[i, lewaKolumna] = liczba;
                liczba++;
            }
            lewaKolumna++;

            if (liczba > rozmiar * rozmiar)
                break;
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

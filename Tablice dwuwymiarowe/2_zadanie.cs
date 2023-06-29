using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int dolnyWiersz = 0;
        int gornyWiersz = 9;
        int lewaKolumna = 0;
        int prawaKolumna = 9;

        while (liczba <= 100)
        {
            // Wypełnianie górnego wiersza (od lewej do prawej)
            for (int j = lewaKolumna; j <= prawaKolumna; j++)
            {
                tablica[dolnyWiersz, j] = liczba;
                liczba++;
            }
            dolnyWiersz++;

            // Wypełnianie prawej kolumny (od góry do dołu)
            for (int i = dolnyWiersz; i <= gornyWiersz; i++)
            {
                tablica[i, prawaKolumna] = liczba;
                liczba++;
            }
            prawaKolumna--;

            // Wypełnianie dolnego wiersza (od prawej do lewej)
            for (int j = prawaKolumna; j >= lewaKolumna; j--)
            {
                tablica[gornyWiersz, j] = liczba;
                liczba++;
            }
            gornyWiersz--;

            // Wypełnianie lewej kolumny (od dołu do góry)
            for (int i = gornyWiersz; i >= dolnyWiersz; i--)
            {
                tablica[i, lewaKolumna] = liczba;
                liczba++;
            }
            lewaKolumna++;
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace Tablica
{
   class Program
   {
        static void Main(string[] args) 
        {
            int ROZMIAR, i;
            ROZMIAR = 10;
            int[] Tablica = new int[ROZMIAR];
            Random random = new Random();
            for (i = 0; i < ROZMIAR; i++)
            {
                Tablica[i] = random.Next(100);


            }

            for (i = 0; i < ROZMIAR; i++)
            {
                Console.WriteLine(Tablica[i]);
            }

            int indeksNajmniejszegoElementu;

            indeksNajmniejszegoElementu = 0;
            int pozycjaDoZapisu;

            for (pozycjaDoZapisu = 0; pozycjaDoZapisu <= ROZMIAR - 1; pozycjaDoZapisu++)
            {
                indeksNajmniejszegoElementu = pozycjaDoZapisu;
                for (i = pozycjaDoZapisu + 1; i <= ROZMIAR - 1; i++)
                {
                    if (Tablica[i] < Tablica[indeksNajmniejszegoElementu])
                    {
                        indeksNajmniejszegoElementu = i;
                    }

                }

                int najmniejszaWartość;

                najmniejszaWartość = Tablica[indeksNajmniejszegoElementu];
                Tablica[indeksNajmniejszegoElementu] = Tablica[pozycjaDoZapisu];
                Tablica[pozycjaDoZapisu] = najmniejszaWartość;

            }

            Console.WriteLine("Tablica po sortowaniu");
            for (i = 0; i <= ROZMIAR - 1; i++);
            {
                Console.WriteLine(Tablica[i]);

            }
        }

   }
    
}

using System;

namespace RysowanieRombu
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_PROBY = 3;
            int proby = 0;

            int wysokosc = 0;
            bool poprawnaWysokosc = false;

           
            while (!poprawnaWysokosc)
            {
                Console.WriteLine("Podaj wysokość rombu (liczba nieparzysta >= 3):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out wysokosc) && wysokosc >= 3 && wysokosc % 2 == 1)
                {
                    poprawnaWysokosc = true;
                }
                else
                {
                    proby++;
                    if (proby >= MAX_PROBY)
                    {
                        Console.WriteLine("Błędna wartość wprowadzona 3 razy. Program zostanie zakończony.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość. Spróbuj ponownie.");
                    }
                }
            }

            Random random = new Random();

            char[] obramowanie = { '#', '@', '|', '*' };
            char[] wnętrze = { '.', ':', '-', '+' };

            int pusteMiejsca = wysokosc / 2;
            int zajeteMiejsca = 1;

            
            for (int i = 0; i < wysokosc / 2; i++)
            {
                for (int j = 0; j < pusteMiejsca; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < zajeteMiejsca; j++)
                {
                    char losoweObramowanie = obramowanie[random.Next(obramowanie.Length)];
                    Console.Write(losoweObramowanie);
                }

                Console.WriteLine();

                pusteMiejsca--;
                zajeteMiejsca += 2;
            }

            
            for (int i = 0; i < zajeteMiejsca; i++)
            {
                char losweWnętrze = wnętrze[random.Next(wnętrze.Length)];
                Console.Write(losweWnętrze);
            }

            Console.WriteLine();

            
            pusteMiejsca = 1;
            zajeteMiejsca -= 2;

            for (int i = 0; i < wysokosc / 2; i++)
            {
                for (int j = 0; j < pusteMiejsca; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < zajeteMiejsca; j++)
                {
                    char losoweObramowanie = obramowanie[random.Next(obramowanie.Length)];
                    Console.Write(losoweObramowanie);
                }

                Console.WriteLine();

                pusteMiejsca++;
                zajeteMiejsca -= 2;
            }
        }
    }
}

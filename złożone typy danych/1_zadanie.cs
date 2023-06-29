using System;

class Program
{
    enum DzienTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    enum EtapPrania
    {
        PoczatkowyPlyn,
        Pranie,
        Plyniecie,
        Obroty
    }

    enum Posilek
    {
        Sniadanie,
        Obiad,
        Kolacja,
        Przekaska
    }

    enum FiguraSzachowa
    {
        Krol,
        Hetman,
        Wieza,
        Goniec,
        Skoczek,
        Pionek
    }

    static void Main()
    {
        DzienTygodnia dzisiaj = DzienTygodnia.Sroda;
        EtapPrania aktualnyEtap = EtapPrania.Pranie;
        Posilek aktualnyPosilek = Posilek.Kolacja;
        FiguraSzachowa wybranaFigura = FiguraSzachowa.Skoczek;

        Console.WriteLine("Dzisiaj jest " + dzisiaj);
        Console.WriteLine("Aktualny etap prania: " + aktualnyEtap);
        Console.WriteLine("Aktualny posilek: " + aktualnyPosilek);
        Console.WriteLine("Wybrana figura szachowa: " + wybranaFigura);
    }
}

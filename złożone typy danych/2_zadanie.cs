using System;

struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}

struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public int ECTS;
}

struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Specjalizacja;
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.Kierunek = "Informatyka";

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "INF101";
        przedmiot.ECTS = 6;

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.TytulNaukowy = "dr";
        nauczyciel.Specjalizacja = "Sztuczna inteligencja";

        Console.WriteLine("Student:");
        Console.WriteLine("Imię: " + student.Imie);
        Console.WriteLine("Nazwisko: " + student.Nazwisko);
        Console.WriteLine("Numer indeksu: " + student.NumerIndeksu);
        Console.WriteLine("Kierunek: " + student.Kierunek);

        Console.WriteLine();

        Console.WriteLine("Przedmiot:");
        Console.WriteLine("Nazwa:");
    }
}


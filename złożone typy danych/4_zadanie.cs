using System;

struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec StudentPlec;

    public enum Plec
    {
        Mezczyzna,
        Kobieta
    }
}

class Program
{
    static void WypelnijStudenta(ref Student student, string nazwisko, int nrAlbumu, double ocena, Student.Plec plec)
    {
        student.Nazwisko = nazwisko;
        student.NrAlbumu = nrAlbumu;

        if (ocena < 2.0)
            student.Ocena = 2.0;
        else if (ocena > 5.0)
            student.Ocena = 5.0;
        else
            student.Ocena = ocena;

        student.StudentPlec = plec;
    }

    static double ObliczSrednia(Student[] grupa)
    {
        double sumaOcen = 0.0;
        int liczbaStudentow = grupa.Length;

        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / liczbaStudentow;
    }

    static void WyswietlStudenta(Student student)
    {
        string plec = student.StudentPlec == Student.Plec.Mezczyzna ? "Mężczyzna" : "Kobieta";
        Console.WriteLine("Nazwisko: " + student.Nazwisko + ", Nr albumu: " + student.NrAlbumu +
            ", Ocena: " + student.Ocena + ", Płeć: " + plec);
    }

    static void Main()
    {
        Student[] grupa = new Student[5];

        WypelnijStudenta(ref grupa[0], "Kowalski", 12345, 4.5, Student.Plec.Mezczyzna);
        WypelnijStudenta(ref grupa[1], "Nowak", 54321, 3.8, Student.Plec.Kobieta);
        WypelnijStudenta(ref grupa[2], "Wiśniewski", 98765, 5.2, Student.Plec.Mezczyzna);
        WypelnijStudenta(ref grupa[3], "Kwiatkowska", 24680, 2.5, Student.Plec.Kobieta);
        WypelnijStudenta(ref grupa[4], "Zielinski", 13579, 4.2, Student.Plec.Mezczyzna);

        Console.WriteLine("Grupa studentów:");
        foreach (var student in grupa)
        {
            WyswietlStudenta(student);
        }

        double srednia = ObliczSrednia(grupa);
        Console.WriteLine("Średnia ocen: " + srednia);
    }
}

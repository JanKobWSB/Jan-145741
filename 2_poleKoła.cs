using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pole koła:");
        double P = Convert.ToDouble(Console.ReadLine());

        double r = Math.Sqrt(P / Math.PI);  
        double O = 2 * Math.PI * r;  

        Console.WriteLine("Obwód koła: " + O);
    }
}

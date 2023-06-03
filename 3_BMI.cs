using System;

    class Program
    { 
       static void Main(string[] args)
       {

        Console.WriteLine("Podaj wagę [kg]:");
        double w = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wzrost [m]:");
        double h = Convert.ToDouble(Console.ReadLine());

        double bmi = w / (h * h);

        Console.WriteLine("Współczynnik BMI: " + bmi);





    }




    
    
    }
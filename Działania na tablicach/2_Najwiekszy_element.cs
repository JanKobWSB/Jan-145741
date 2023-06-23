using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 10, 8, 3 };

        int minValue = array.Min();
        int maxValue = array.Max();

        Console.WriteLine("Najmniejszy element: " + minValue);
        Console.WriteLine("Największy element: " + maxValue);

        Console.ReadLine();
    }
}

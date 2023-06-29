using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 2.5, 3.7, 1.9, 4.2 };
        double average = CalculateRecursiveAverage(numbers, numbers.Length);
        Console.WriteLine(average); // Output: 3.075
    }

    static double CalculateRecursiveAverage(double[] numbers, int size)
    {
        if (size == 0)
        {
            return 0;
        }

        double sum = numbers[size - 1] + CalculateRecursiveAverage(numbers, size - 1);
        double average = sum / size;
        return average;
    }
}

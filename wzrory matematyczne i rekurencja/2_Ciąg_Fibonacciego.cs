using System;

public class Program
{
    public static void FibonacciSequence(int n)
    {
        int firstNumber = 0;
        int secondNumber = 1;

        Console.Write("Ciąg Fibonacciego ({0} wyrazów): ", n);

        for (int i = 0; i < n; i++)
        {
            Console.Write(firstNumber + " ");

            int nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego: ");
        int n = Convert.ToInt32(Console.ReadLine());

        FibonacciSequence(n);
    }
}
using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateRandomArray(10); // Generowanie tablicy o rozmiarze 10 z losowymi wartościami
        Console.WriteLine("Tablica przed odwróceniem:");
        PrintArray(array);

        Console.WriteLine("\nTablica po odwróceniu:");
        ReversePrintArray(array);

        Console.ReadLine();
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); // Losowanie liczby całkowitej z zakresu 1-100
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void ReversePrintArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
    }
}

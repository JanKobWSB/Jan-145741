using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 10, 8, 3 };

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        SelectionSort(array);

        Console.WriteLine("\nTablica po sortowaniu:");
        PrintArray(array);

        Console.ReadLine();
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Zamiana miejscami elementów
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}

using System;
using System.Linq;

public class SelectionSort
{
    public static void SelectionSort(int[] dizi)
    {
        int n = dizi.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (dizi[j] < dizi[minIndex])
                {
                    minIndex = j; 
                }
            }


            if (minIndex != i)
            {
                int temp = dizi[i];
                dizi[i] = dizi[minIndex];
                dizi[minIndex] = temp;
            }

        }

        Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", dizi)}]");
    }

    public static void Main(string[] args)
    {
        int[] siralanacakDizi = { 8, 15, 2, 49, 63, 21, 27, 60, 76 };
        SelectionSort(siralanacakDizi);
    }
}



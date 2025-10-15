using System.Security.AccessControl;
using System;
using System.Linq;

public class InsertionSort3
{
    public static void InsertionSort(int[] dizi)
    {
        int n = dizi.Length;

        for(int i=1;i<n;i++)
        {
            int key = dizi[i];
            int j = i - 1;
            
            while(j>=0 && dizi[j]> key)
            {
                dizi[j + 1] = dizi[j];
                j = j - 1;
            }

            dizi[j + 1] = key;
        }
    }
    
    public static void Main(string[] args)
    {
        int[] siralanacakDizi = {12,11,13,5,6};
        InsertionSort(siralanacakDizi);
        Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", siralanacakDizi)}]");
    }
}
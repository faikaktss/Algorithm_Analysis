/*
Soru: Selection Sort Uygulaması

Aşağıdaki tamsayı dizisini Selection Sort algoritmasını kullanarak sıralayın. 

Lütfen her adımda hangi elemanı bulduğunuzu ve hangi elemanla yer değiştirdiğinizi (swap) belirtin.

Verilen Dizi:

Dizi=[14,33,27,10,35,19]
*/

using System;
using System.Linq;

public class SelectionSort2
{
    int MinIndex;
    public static void SelectionSort(int[] dizi)
    {
        int n = dizi.Length;
        for(int i=0; i<n-1; i++)
        {
            MinIndex = i;
            
            for(int j = i+1; j<n; j++)
            {
                if (dizi[j] < dizi[MinIndex])
                    MinIndex = j;
            }
        }
        
        if(MinIndex != i)
        {
            int temp = dizi[i];
            dizi[i] = dizi[MinIndex];
            dizi[MinIndex] = temp;
        }
        Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", dizi)}]");
    }
    
    public static void Main(string[] args)
    {
        int[] SiralanacakDizi = {14,33,27,10,35,19};
        SelectionSort(SiralanacakDizi);
    }
}
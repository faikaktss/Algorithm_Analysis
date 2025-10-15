using System;
using System.Linq;

public class InsertionSort
{
    public static void InsertionSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for(int i=1; i<n; i++) // ilk eleman sıralanmış olarak kabuk edilir(faik)
        {
            int key = dizi[i]; // Bir anahtar belirlemek zorundayız(faik)
            int j = i - 1; // Anahtardan bir önceki kısmı alıyoruz(faik)
            
            while(j>=0 && dizi[j] >key)
            {
                dizi[j + 1] = dizi[j];
                j = j - 1;
            }
            dizi[j + 1] = key;
        }
    }   
    
    public static void Main(string[] args)
    {
        int[] siralanacakDizi = {8,15,2,49,63,21,27,60,76};
        InsertionSort(siralanacakDizi);
    }
}
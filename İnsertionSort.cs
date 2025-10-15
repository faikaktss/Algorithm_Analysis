using System;
using System.Linq;

public class InsertionSort
{
    public static void InsertionSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for(int i=0; i<n; i++)
        {
            int key = dizi[i];
            int j = i - 1;
            
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
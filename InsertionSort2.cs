using System.Security.AccessControl;
/*
Soru: Insertion Sort Uygulaması

Aşağıdaki tamsayı dizisini Insertion Sort (Eklemeli Sıralama) algoritmasını kullanarak küçükten büyüğe sıralayınız.

Verilen Dizi:

Dizi=[5,2,4,6,1,3]
*/

using System;
using System.Linq;

public class InsertionSort2
{
    public static void InsertionSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for(int i=1; i<n;i++)
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
        int[] siralanacakDizi = {5,2,4,6,1,3};
        InsertionSort(siralanacakDizi);
    }
}
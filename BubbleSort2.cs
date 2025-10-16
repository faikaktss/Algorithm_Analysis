/*
Soru: Bubble Sort Uygulaması

Aşağıdaki tamsayı dizisini Bubble Sort (Kabarcık Sıralaması) algoritmasını kullanarak küçükten büyüğe doğru sıralayınız.

Lütfen dizinin her bir tam tur (dış döngü) 
sonunda nasıl göründüğünü gösteriniz ve o turda hangi elemanın
 dizinin sonuna yerleştiğini belirtiniz.

Verilen Dizi:
Dizi=[8,1,6,3,5,2]

*/

using System;
using System.Linq;

public class BubbleSort2
{
    public static void BubbleSort(int[] dizi)
    {
        int n = dizi.Length;
        
        for(int i=0; i<n-1;i++)
        {
            bool degisim = false;
            for(int j=0;j<n-1-i;j++)
            {
                if(dizi[j] > dizi[j+1])
                {
                    int temp = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi[j + 1] = temp;
                    degisim = true;
                }
            }
            if(!degisim)
                break;
            Console.WriteLine($"{i+1}. Tur: [{string.Join(", ", dizi)}] - {dizi[n-1-i]} dizinin sonuna yerleşti.");
        }
    }
    public static void Main(string[] args)
    {
        int[] dizi= {8,1,6,3,5,2};
        BubbleSort(dizi);   
        Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", dizi)}]"); 
    }
}

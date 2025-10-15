using System.Security.AccessControl;
using System;

public class  BubbleSort(int[] dizi)
{
    public static void bubbleShort(int[] dizi)
    {
        for (int i = 0; i < dizi.Length - 1; i++)
        {
            bool degisim = false;
            for (int j = 0; j < dizi.Length - 1 - i; j++)
            {
                if (dizi[j] > dizi[j + 1])
                {
                    int temp = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi(j + 1) = temp;
                    degisim = true;
                }
            }

            if (!degisim)
                break;
        }
    }
    
    public static void Main(string[] args)
    {
        int[] dizi = {64,34,25,12,22,11,90};
        bubbleShort(dizi);
        Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", dizi)}]");
    }
}
using System.Security.AccessControl;
/*
Aşağıda verilen tam sayı dizisini, Shell Sıralaması (Shell Sort) 
algoritmasını kullanarak artan düzende sıralayınız.

Dizi (Array):

A=[28,12,55,7,60,20,41,15]
*/

using System;
using System.Linq;

public class ShellSıralaması2
{
    public static void ShellSort(int[] dizi)
    {
        int n = dizi.Length;
        int aralik = n / 2;

        for(int i=aralik;i<n;i++)
        {
            int gecici = dizi[i];
            int j = i;
            while(j>=aralik && dizi[j-aralik]>gecici)
            {
                dizi[j] = dizi[j - aralik];
                j -= aralik;
            }
            dizi[j] = gecici;
        }
        dizi /= 2;
    }
    
    public static void Main(string[] args)
    {
        int[] dizi = {28,12,55,7,60,20,41,15};
        ShellSort(dizi);
        Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", dizi)}]");
    }
}
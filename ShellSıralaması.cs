using System;
using System.Linq;

public class ShellSıralaması
{
    public static void ShellSort(int[] dizi)
    {
        int n = dizi.Length;
        int aralik = n / 2; // Bu gap dır yani aralık belirlemek için kullandığımız kısım
        
        while(aralik>0)
        {
            for(int i=aralik;i<n;i++)
            {
                int gecici = dizi[i];
                int j = i;
                
                while(j>= aralik && dizi[j-aralik]>gecici)
                {
                    dizi[j] = dizi[j - aralik];
                    j -= aralik;
                }
                dizi[j] = gecici;
            }

            aralik /= 2;
        }
        

    }
            public static void Main(string[] args)
        {
            int[] sayilar = {12, 34, 54, 2, 3};
            ShellSort(sayilar);
            Console.WriteLine($"Sıralanmış Dizi: [{string.Join(", ", sayilar)}]");
        }
}
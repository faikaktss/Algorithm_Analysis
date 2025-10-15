using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgoritmaAnalizi
{
    public class BigO
    {
        /*
        Soru: 1,15,8,19,-85,6,34,2,47,51,21,38,65 sayılar isimli dizi için lineer doğrusal arama yaparak 65. sayının
        indexini ekrana yazdıran programı  yaz 
        Toplam çalışma süresini T(n) cinsinden ifade et
        */
        
        static void Main()
        {
            int [] sayilar = { 1, 15, 8, 19, -85, 6, 34, 2, 47, 51, 21, 38, 65 };
            int arananSayi = 65;
            System.Console.WriteLine(arama(sayilar, sayilar.Length, arananSayi));
        }

        static int arama(int [] A , int N, int sayi)
        {
            int i 0; // -> 1
            while(i<N) // ->  (n+1)
            {
                if(A[i] == sayi) // -> n
                {
                    System.Console.WriteLine(A[i]); // -> n 
                    break; // -> n
                    i++; // -> n
                }
            }
            if (i < N) // -> 1
                return i;
            else // -> 1
                return -1;
        }
        
        
        
        
    
    }
}
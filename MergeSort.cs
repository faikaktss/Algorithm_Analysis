using System.Security.AccessControl;
using System;
using System.Linq;

public class MergeSort()
{
    public static void MergeSort(int[] dizi, int sol, int sag)
    {
        if(sol<sag)
        {
            int orta = (sol + sag) / 2;
            MergeSort(dizi, sol, orta);
            MergeSort(dizi, orta + 1, sag);
            Merge(dizi, sol, orta, sag);
        }
    }   
    
    private static void Merge(int[] dizi, int sol, int orta,int sag)
    {
        int n1 = orta - sol + 1;
        int n2 = sag - orta;

        int[] SolDizi = new int[n1];
        int[] sagDizi = new int[n2];

        int i, j;
        for(i=0;i<n1;i++)
        {
            SolDizi[i] = dizi[sol + i];
        }
        for(j=0;j<n2;j++)
        {
            sagDizi[j] = dizi[orta + 1 + j];
        }

        i = 0;
        j = 0;
        int k = sol;
        
    while (i < n1 && j < n2)
    {
        if (SolDizi[i] <= SagDizi[j])
        {
            dizi[k] = SolDizi[i];
            i++;
        }
        else
        {
            dizi[k] = SagDizi[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        dizi[k] = SolDizi[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        dizi[k] = SagDizi[j];
        j++;
        k++;
    }
    }
}
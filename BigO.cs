using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgoritmaAnalizi
{
    public class BigO
    {
        // O(1) - Sabit zaman karmaşıklığı
        public int ConstantTime(int[] array)
        {
            return array[0]; // İlk elemanı döndür
        }

        // O(n) - Doğrusal zaman karmaşıklığı
        public int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }

        // O(n²) - Karesel zaman karmaşıklığı
        public void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // O(log n) - Logaritmik zaman karmaşıklığı
        public int BinarySearch(int[] sortedArray, int target)
        {
            int left = 0;
            int right = sortedArray.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (sortedArray[mid] == target)
                    return mid;

                if (sortedArray[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        // O(n log n) - Logaritmik doğrusal zaman karmaşıklığı
        public void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                    array[k++] = leftArray[i++];
                else
                    array[k++] = rightArray[j++];
            }

            while (i < n1)
                array[k++] = leftArray[i++];

            while (j < n2)
                array[k++] = rightArray[j++];
        }

        // Algoritmaların performansını test etmek için
        public void PerformanceTest()
        {
            var watch = new Stopwatch();
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            
            Console.WriteLine("Big O Notation Örnekleri:");
            Console.WriteLine("------------------------");
            
            // O(1) test
            watch.Start();
            int first = ConstantTime(array);
            watch.Stop();
            Console.WriteLine($"O(1) - İlk eleman: {first}, Süre: {watch.ElapsedTicks} ticks");
            
            watch.Reset();
            
            // O(n) test
            watch.Start();
            int index = LinearSearch(array, 22);
            watch.Stop();
            Console.WriteLine($"O(n) - Linear Search: Index {index}, Süre: {watch.ElapsedTicks} ticks");
        }
    }

    // Program entry point
    class Program
    {
        static void Main(string[] args)
        {
            var bigO = new BigO();
            bigO.PerformanceTest();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
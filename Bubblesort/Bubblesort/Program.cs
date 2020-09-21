using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 5, 3, 8, 4, 6 };
            int[] sortedArray = bubbleSort(x);
            Console.WriteLine("sorted: " );
            foreach (var p in x)
            {
                Console.Write(p + " ");
            }
           
        }
        static int[] bubbleSort (int[] array)
        {
            int temp;
            for (int k = 0; k <= array.Length - 2; k++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
    }
}

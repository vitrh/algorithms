using System;
using System.IO.MemoryMappedFiles;

namespace QuickSort
{
    class Program
    {
        public static void quicksort(int[] array)
        {
            quicksort(array, 0, array.Length - 1);
        }
        /// <summary>
        /// das Pivot-Element, wird von der Funktion "teiler" ausgewählt + Methode quicksort wird aufgerufen
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private static void quicksort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = teiler(array, low, high);
                if (pivot > 1)
                {
                    quicksort(array, low, pivot - 1);
                }
                if (pivot + 1 < high)
                {
                    quicksort(array, pivot + 1, high);
                }

            }
        }
        /// <summary>
        /// SORTIERT DAS PIVOT. setzt Pivot an richtiger stelle und die Array links und rechts werden mit quicksort sortiert.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private static int teiler(int[] array, int low, int high)
        {
            int pivot = array[low];
            while (true)
            {


                while (array[low] < pivot)
                {
                    low++;
                }
                while (array[high] > pivot)
                {
                    high--;
                }
                if (low < high)
                {
                    if (array[low] == array[high])
                    {
                        
                        return high;

                    }
                    // wenn links kleiner als rechts, dann 
                    int temp = array[low];
                    array[low] = array[high];
                    array[high] = temp;
                }
                else
                {
                    return high;
                }
            }

        }
       
        static void Main(string[] args)
        {
            int[] newArray = new int[] { 15, 3, 9, 8, 5, 2, 7, 1, 6 }; // neues Array wird erstellt
            Console.WriteLine("Original Array: ");
            foreach (var item in newArray)  // Jedes einzelne Element im Array wird in der Konsole ausgegeben
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            quicksort(newArray, 0, newArray.Length - 1); // Methode wird aufgerufen, Array wird sortiert 
            Console.WriteLine();

            Console.WriteLine("Sortiertes Array : ");
            foreach (var item in newArray)
            {
                Console.Write(" " +item);
            }
        }
    }
}

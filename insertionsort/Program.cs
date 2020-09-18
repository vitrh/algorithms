using System;

namespace insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 4, 3, 2, 1 };
            int links = 0;
            /// Notation von O(n^2) im worstcase, average case, > best case O(n)
            if (links < array.Length)  // O(1)
            {

                int min = links;
                for (int i = links; i < array.Length - 1; i++) // O(n)
                {

                    for (int next = i + 1; next > 0; next--) // O(1) , O(n)
                    {
                        if (array[next - 1] > array[next])  // O(1)
                        {
                            int j = array[next - 1];
                            array[next - 1] = array[next];
                            array[next] = j;

                        }


                    }

                }

            }
            foreach (var item in array)
            {
                Console.WriteLine("sorted:   " + item + " ");
            }
        }
    }
}

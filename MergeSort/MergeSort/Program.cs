using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[10] {3,1,3,1,5,9,2,6,5,4 };
            merge_sort(ref test[10]);
            Console.WriteLine("sortiert:  ");
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            
        }
       private static int[] merge(ref int[] links, ref int[] rechts)
        {
            int[] newArray = new int[links.Length + rechts.Length];

            //index = register
            int indexLinks = 0;
            int indexRechts = 0;
            int indexErg = 0;

            while (indexLinks < links.Length && indexRechts < rechts.Length)
            {
                if (links[indexLinks] < rechts[indexRechts])
                {
                    newArray[indexErg] = links[indexLinks];
                    indexLinks = indexLinks + 1;
                }
                else
                {
                    newArray[indexErg] = rechts[indexRechts];
                    indexRechts = indexRechts + 1;
                }
                indexErg = indexErg + 1;

            }

            while (indexLinks < links.Length)
            {
                newArray[indexErg] = links[indexLinks];
                indexLinks += 1;
                indexErg += 1;
            }

            while (indexRechts < rechts.Length)
            {
                newArray[indexErg] = rechts[indexRechts];
                indexRechts += 1;
                indexErg += 1;

            }

            return newArray;
        }
        /// <summary>
        /// Teilt die Arrays in der mitte auf (links & rechts)
        /// </summary>
        /// <param name="arr"></param>
        public void merge_sort(ref int[] arr)
        {
            if (arr.Length > 1)
            {
                // Teilt array in der mitte
                int mitte = Convert.ToInt32(arr.Length / 2);

                //linke seite des arrays
                int[] links = new int[mitte];

                //sortiert linke seite
                for (int i = 0; i <= links.Length -1; i++)
                {
                    links[i] = arr[i];
                }


                int[] rechts = new int[arr.Length - mitte];
                for (int i = mitte; i <= arr.Length - 1; i++)
                {
                    rechts[i - mitte] = arr[i]; 
                }

                merge_sort(ref links);
                merge_sort(ref rechts);

                arr = merge(ref links, ref rechts);
            }
        }

    }
}

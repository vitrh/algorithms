using System;

namespace unknownalgorithm4
{
   /// <summary>
   /// Rekursiver Such/Zählalgorithmus
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] Res = new int[] {9,4,2,78,2,42,1}; // barlänge ist 7
            Console.WriteLine("Res = " + Foo(Res, 2, 0));
        }
        /// <summary>
        /// Vergleicht die gesuchte Zahl mit dem Array Elementen 
        /// und gibt die Anzahl des vorkommens der gesuchten Zahl im Array aus
        /// </summary>
        /// <param name="Bar">Array</param>
        /// <param name="Star">Gesuchte Zahl</param>
        /// <param name="Megastar">Laufvariable</param>
        /// <returns>Anzahl der gesuchten Zahl im Array</returns>
        public static int Foo(int[] Bar, int Star, int Megastar) //Komplexität O(n^2)
        {

            if (Megastar > Bar.Length - 1)  // O(n)
            {
                return 0;
            }
            if (Star == Bar[Megastar])  // O(n)
            {
                return (Foo(Bar, Star, Megastar + 1)) + 1;
            }
            else
            {
                return (Foo(Bar, Star, Megastar + 1));
            }


        }
    }
}

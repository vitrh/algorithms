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
            int[] Res = new int[] {3,4,5,6,3,3,3}; // barlänge ist 7
            Console.WriteLine(Foo(Res, 3, 0));
        }
        /// <summary>
        /// Vergleicht die gesuchte Zahl mit dem Array Elementen 
        /// und gibt die Anzahl des vorkommens der gesuchten Zahl im Array aus
        /// </summary>
        /// <param name="Bar">Array</param>
        /// <param name="Star">Gesuchte Zahl</param>
        /// <param name="Megastar">Laufvariable</param>
        /// <returns>Anzahl der gesuchten Zahl im Array</returns>
        public static int Foo(int[] Bar, int Star, int Megastar)
        {
           
            if (Megastar > Bar.Length - 1 ) //megastar ist 0 ->      0 > 7?
            {
                return 0;
            }
            if (Star == Bar[Megastar]) // 2 ==  ?? -> +1
            {
                return (Foo(Bar, Star, Megastar + 1)) + 1;
            }
            else
            {
                return  (Foo(Bar, Star, Megastar + 1)); 
            }
           
           
        }
    }
}

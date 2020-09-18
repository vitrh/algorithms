using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;

namespace hashverfahren
{
    class Program
    {
        public static bool SearchTableEntry(String value, Hashtable table)
        {
            foreach (DictionaryEntry entry in table)
            {

                if (entry.Value == value)
                {
                    Console.WriteLine("Found Entry! The Entry key:{0} & Entry Value:{1}", entry.Key,entry.Value);
                    return true;
                }
            }
            Console.WriteLine("Entry Not FOUND!");
            return false;
        }

       public static void DeleteTableEntry(String value, Hashtable table)
        {
            if (table.ContainsValue(value))
            {
                   table.Remove(value.GetHashCode());
                Console.WriteLine("Deleted Entry with Value: {0}", value);
            } 
            
        }
        public static void PrintHashtableValues(Hashtable table)
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
        }
        public static void PrintValues(String[] myArr, char mySeparator)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.Write($"{mySeparator}{myArr[i]}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            var myTargetArray = new String[8];
            myTargetArray[0] = "The";
            myTargetArray[1] = "The";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumps";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
           

            PrintValues(myTargetArray, ' ');

            Hashtable table = new Hashtable();
            
            foreach (var item in myTargetArray)
            {
                if (table.ContainsValue(item)) 
                {
                    table.Add(item.GetHashCode(), item);
                }
                else
                {
                    table.Add(item.GetHashCode() + 1, item);
                }
               
               
            }

            PrintHashtableValues(table);
            SearchTableEntry("lazy", table);
            DeleteTableEntry("The", table);
            PrintHashtableValues(table);
        
        }

    }
}

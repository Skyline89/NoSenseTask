using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace No_Sense
{
    class Program     
    {
        public static IEnumerable<string> StringOfNumbers(string count)
        {
            for (var i = 0; i < count.Length; i++)
            {
                Console.WriteLine("please enter");
            }
            yield return count ;
        }
        public static void Main()
        {
            List<string> numberList = new List<string>();
            Predicate<int[]> checking = CheckingElement;
            //Console.WriteLine("please enter numbers separate them with ',':");
            //var listOfNumbers = Console.ReadLine();
            //var realNumbers = Array.ConvertAll(listOfNumbers.Split(','), int.Parse);
            //var result = checking(realNumbers);
            //Console.WriteLine(result);
        }

         public static bool CheckingElement(int[] array)
         {
             
            return Array.Exists(array, number => number == 12); ;
        }
        
    }
}

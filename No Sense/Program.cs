using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace No_Sense
{
    class Program     
    {
        ////public delegate 
        ////public static bool PredicateString(string listOfNumbers)
        ////{
        ////        return false;
        ////}
        static void Main(string[] args)
        {
            Console.WriteLine("please enter numbers separate them with ',':");
            var listOfNumbers = Console.ReadLine();
            int[] RealNumbers = Array.ConvertAll(listOfNumbers.Split(','), int.Parse);
            Func<>
            NewRecord (realNumbers);
            //Predicate<string> checking = PredicateString;

        }

        public static int RecordCheking(string record)
        {
            return record.c;
        }

        public static int NewRecord(int[] arrayOfNumbers)
        {
            foreach (var record in arrayOfNumbers)
            {
                if Array.
            }
        }
    }
}

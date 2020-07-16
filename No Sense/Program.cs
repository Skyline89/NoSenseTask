using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;

namespace No_Sense
{
    public static class EnumerExstension
    {
        int
        public static IEnumerable<T> ThisDoesntMakeAnySense<T>(this IEnumerable<T> list, Func<int, int, bool> checking,
            Func<T,T> createNewRecord)
        {
            foreach (var item in list)
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item), "Please enter number instead of null");
            }
            return default;
            bool res = checking(list,12)
        }

        public static bool IsThere(int [] numbers, int element)
        {
            foreach (var number in numbers)
            {
                if (number == element)
                    return true;
            }

            return false;
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("please enter numbers and divide them with ',':");
            var str = Console.ReadLine().Split(',');
            var numbers = Array.ConvertAll(str,int.Parse);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }

        public static bool CheckingArrayElement(int[] array, int element)
        {
            return Array.Exists(array, x => x == element);
        }
    }
}

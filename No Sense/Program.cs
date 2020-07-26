using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;

namespace No_Sense
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("please enter numbers and divide them with ',':");
            var str = Console.ReadLine().Split(',');
            var numbers = Array.ConvertAll(str,int.Parse);
            var sense = numbers.ThisDoesntMakeAnySense(str, n => n.Equals(5), x => x);
            foreach (var values in sense)
            {
                Console.WriteLine(values);
            }
            //Func<int, bool> checking = (int num) => num.Equals(23);
            //Func<int, int> create = (int numb) => numb;
        }
    }
}

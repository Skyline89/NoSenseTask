using System;
using System.Collections.Generic;
using System.Linq;

namespace No_Sense
{
    public static class EnumerExstension
    {
        public static IEnumerable<TSource> ThisDoesntMakeAnySense<TSource>(this IEnumerable<TSource> list, string[] numbers, Func<TSource,bool> predicate, Func<TSource,TSource> createNewRecord)
        {
            foreach (var element in list)
            {
                if (predicate(element))
                    yield return default;
            }

            foreach (var item in list)
            {
                if (predicate(item) == false)
                    yield return createNewRecord(item);
            }

            foreach (var number in numbers)
            {
                if (number == null)
                    throw  new ArgumentNullException(nameof(list), "please enter number instead of null");
            }

            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers), "It's not valid array");

        }
    }
}
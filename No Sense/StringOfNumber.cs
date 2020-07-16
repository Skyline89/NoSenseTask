using System.Collections;
using System.Collections.Generic;

namespace No_Sense
{
    public class StringOfNumber: IEnumerable<string>
    {
        public StringOfNumber(string[] stringNumbers)
        {
            this.PrintString = stringNumbers;
        }


        public string[] PrintString { get; }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var itemNumber in PrintString)
                yield return itemNumber;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
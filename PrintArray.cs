using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class PrintArray<T>
    {
        private T[] inputarray;

        public PrintArray(T[] inputArray)
        {
            this.inputarray = inputArray;
        }

        public void toPrint()
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine(element);
            }
        }
    }
}

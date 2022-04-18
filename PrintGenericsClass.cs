using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArray
{
    public class PrintGenericsClass<T>
    {
        private T[] inputArray;

        public PrintGenericsClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrintArray() 
        {
            foreach (var element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n-------------------");
        }
    }
}

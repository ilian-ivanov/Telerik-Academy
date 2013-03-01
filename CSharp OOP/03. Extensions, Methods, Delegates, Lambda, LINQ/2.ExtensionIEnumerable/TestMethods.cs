using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExtensionIEnumerable
{
    class TestMethods
    {
        static void Main()
        {
            double[] array = { 1, 5, 35, 21, 81, 84, 9, 42 };
            byte[] arrayByte = { 1, 5, 35, 21, 81, 84, 9, 42 };
            string[] strArray = {"aman","pesho","as","d","s","a" };
            string str = "pesho";

            // works with string because it is array of chars
            Console.WriteLine(str.MinValue());
            Console.WriteLine(str.MaxValue());
            // not compiled
            //Console.WriteLine(str.ProductValue());


            //Console.WriteLine(array.MinValue<int>());
            Console.WriteLine(strArray.MinValue<string>());

            Console.WriteLine(array.MinValue());

            Console.WriteLine(strArray.SumValue<string>());
            Console.WriteLine(arrayByte.SumValue<byte>());
            Console.WriteLine(array.AverageValue<double>());
        }
    }
}

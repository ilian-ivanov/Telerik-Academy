using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList567
{
    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(3);
            GenericList<string> listNames = new GenericList<string>(2);

            listNames.Add("Pesho");
            listNames.Add("Avan");
            Console.WriteLine(listNames);
            Console.WriteLine(listNames.Min<string>());

            list.Add(1);
            list.Add(2);
            list.Add(1);
            
            //list.RemoveElement(2);
            //list.Clear();
            list.Insert(10, 0);
            list.Add(-3);
            list.Add(13);
            list.Add(3);
            list.TakeElement(1);
            Console.WriteLine(list);
            
            
            Console.WriteLine(list.FindElement(10));
            
            list.FindElement(2);

            Console.WriteLine("Minimal value: " + list.Min<int>());
            Console.WriteLine("Maximal value: " + list.Max<int>());
            Console.WriteLine("Capacity: " + list.Capacity);
            Console.WriteLine("Count: " + list.Count);

        }
    }
}

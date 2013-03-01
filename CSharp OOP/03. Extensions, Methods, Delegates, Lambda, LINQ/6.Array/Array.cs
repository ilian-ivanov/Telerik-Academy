using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Array
{
    class Array
    {
        static void Main()
        {            
            int[] array = { 1, 5, 35, 21, 81, 84, 9, 42 };

  // with lambda ----------------------------------------------------------------          
            var divisible = array.Where(x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

   // with LINQ ------------------------------------------------------------------
            var divisebleLINQ =
                from x in array
                where x % 3 == 0 && x % 7 == 0
                select x;

            foreach (var x in divisebleLINQ)
            {
                Console.WriteLine(x);
            }
        }
    }
}

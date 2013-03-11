using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonTest
{
    class Test
    {
        static void Main()
        {
            Person person1 = new Person();
            Console.WriteLine(person1);

            person1.FirstName = "Ivan";
            Console.WriteLine(person1);

            person1.Age = 10;
            Console.WriteLine(person1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3.Student
{
    class Test
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", 1234);
            Student student2 = new Student("Pesho", 123);

            // makes check with equals
            Console.WriteLine("student1 is equals to student2 = {0}",student1.Equals(student2));
            // makes check with !=
            if (student1 != student2)
            {
                Console.WriteLine("{0} != {1}", student1, student2);
            }

            // makes second student to be equal to first
            student2.FirstName = "Ivan";

            // makes again two types check
            Console.WriteLine("student1 is equals to student2 = {0}", student1.Equals(student2));
            if (student1 == student2)
            {
                Console.WriteLine("{0} == {1}", student1, student2);
            }

            // checks if are Clone method is deep
            Student student3 = student1.Clone();
            student3.FirstName = "Mitko";
            Console.WriteLine(student1.FirstName);
            student3.Specialty = Specialty.Marketing;
            Console.WriteLine(student1.Specialty);

            // test compare method
            Console.WriteLine(student1.CompareTo(student2));

        }
    }
}

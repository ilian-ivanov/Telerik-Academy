using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirstBeforeLastName
{
    public class Student
    {
        public string FirstName  {get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class StudentsTest
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                 new Student {FirstName = "Ivan", LastName = "Peshev", Age = 10},
                 new Student {FirstName = "Aesho", LastName = "Pesh", Age = 23},
                 new Student {FirstName = "Pesho", LastName = "Aeshev", Age = 21},
                 new Student {FirstName = "Pesho", LastName = "Zeshev", Age = 25},
            };

 // exercise 3 ------------------------------------------------------------------
            var names =
                from name in students
                where name.FirstName.CompareTo(name.LastName) == -1
                select name;

            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            Console.WriteLine();
            foreach (var item in names)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine();

 // exercise 4 -----------------------------------------------------------------
            var ages =
                from age in students
                where age.Age > 18 && age.Age < 24
                select age;

            Console.WriteLine("The students between 18 and 24 years: ");
            Console.WriteLine();
            foreach (var item in ages)
            {
                Console.WriteLine("{0} {1} is {2} years old.", item.FirstName, item.LastName, item.Age);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine();

 // exercise 5 -------------------------------------------------------------------
            // write with lambda
            var orderDescending = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            Console.WriteLine("Students in descending order.");
            foreach (var student in orderDescending)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);                
            }


            Console.WriteLine();
            // write with LINQ
            var descendingOrder =
                from name in students
                orderby name.FirstName descending, name.LastName descending
                select name;

            foreach (var student in descendingOrder)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);                 
            }
        }
    }
}

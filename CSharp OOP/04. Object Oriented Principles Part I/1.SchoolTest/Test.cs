using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    class Test
    {
        static void Main()
        {
            Discipline dis = new Discipline("Math", 8, 10);
            Discipline[] disciplines = new Discipline[1];
            disciplines[0] = dis;
            
            People men = new People("Pesho");
            
            Student ivan = new Student("Ivan", 13);
            Student[] students = new Student[1];
            students[0] = ivan;
            
            Teacher first = new Teacher("Ivanov", disciplines);
            Teacher[] teachers = new Teacher[1];
            teachers[0] = first;

            ivan.FreeText = "pesho";

            SchoolClass classA = new SchoolClass(students, teachers, "12v");
            SchoolClass[] classes = new SchoolClass[1];

            School school = new School(classes);

            
            Console.WriteLine(ivan.Name);
            Console.WriteLine(men.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class SchoolClass : IOptional
    {
        private string nameOfClass; 
        private Student[] students;
        private Teacher[] teachers;
        private string freeText;

        // CONSTRUCTORS ----------------------------------------------------------------
        public SchoolClass(Student[] students, Teacher[] teachers, string nameOfClass)
            : this(students, teachers, nameOfClass, null)
        {
        }

        public SchoolClass(Student[] students, Teacher[] teachers, string nameOfClass, string freeText)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.NameOfClass = nameOfClass;
            this.freeText = freeText;
        }

        // PROPERTIES ---------------------------------------------------------------
        public Student[] Students
        {
            get { return this.students; }
            set 
            {
                if (value.Length > 0)
                {
                    this.students = value;
                }
                else
                {
                    throw new ArgumentException("The class must have atleast 1 student!");
                }
            }
        }

        public Teacher[] Teachers
        {
            get { return this.teachers; }
            set
            {
                if (value.Length > 0)
                {
                    this.teachers = value;
                }
                else
                {
                    throw new ArgumentException("The class must have atleast 1 teacher!");
                }
            }
        }

        public string NameOfClass
        {
            get { return this.nameOfClass; }
            set
            {
                if (value != string.Empty && value.Length >= 2)
                {
                    this.nameOfClass = value;
                }
                else
                {
                    throw new ArgumentException("The class name can't be empty or less than 2 characters!");
                }
            }
        }

        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }
    }
}

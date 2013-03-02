using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassHuman
{
    public class Student : Human
    {
        private int grade;

        // CONSTRUCTOR --------------------------------------------------------
        public Student(string firstName, string lastName, int grade) : base (firstName, lastName)
        {
            this.Grade = grade;
        }

        // PROPERTY --------------------------------------------------------
        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value > 0 && value < 13)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException("The grade must be between 1 and 12 including!");
                }
            }
        }

        // METHODS --------------------------------------------------
        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public override string ToString()
        {
            return string.Format("I am {0} {1} and I am in {2} grade.", 
                GetFirstName(), GetLastName(), this.grade);
        }
    }
}

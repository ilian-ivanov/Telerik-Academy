using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class Student : People, IOptional
    {
        private uint classNumber;
        private string freeText;

        // CONSTRUCTORS ---------------------------------------------------------
        public Student(string name, uint classNumber)
            : this(name, classNumber, null)
        {
        }

        public Student(string name, uint classNumber, string freeText) 
            : base(name) 
        {
            this.ClassNumber = classNumber;
            this.freeText = freeText;
        }

        // PROPERTIES ------------------------------------------------------
        public uint ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                // TO DO: better check for class numbers
                if (value != 0)
                {
                    this.classNumber = value;
                }
                else
                {
                    throw new ArgumentException("The number can't be negative or 0!");
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

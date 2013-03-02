using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class Teacher : People, IOptional
    {
        private Discipline[] disciplines;
        private string freeText;

        // CONSTRUCTORS ----------------------------------------------------------------
        public Teacher(string name, Discipline[] disciplines)
            : this(name, disciplines, null)
        {
        }

        public Teacher(string name, Discipline[] disciplines, string freeText)
            : base(name)
        {
            this.Disciplines = disciplines;
            this.freeText = freeText;
        }

        // PROPERTIES -------------------------------------------------------------
        public Discipline[] Disciplines
        {
            get { return this.disciplines; }
            set 
            {
                if (value.Length > 0)
                {
                    this.disciplines = value;
                }
                else
                {
                    throw new ArgumentException("The teacher must have atleast 1 discipline!");
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

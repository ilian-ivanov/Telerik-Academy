using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class School
    {
        private SchoolClass[] classes;

        public School(SchoolClass[] classes)
        {
            this.Classes = classes;
        }

        public SchoolClass[] Classes
        {
            get { return this.classes; }
            set
            {
                if (value.Length > 0)
                {
                    this.classes = value;
                }
                else
                {
                    throw new ArgumentException("The school must have atleast 1 class!");
                }
            }
        }
    }
}

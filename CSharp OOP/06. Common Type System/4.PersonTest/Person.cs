using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonTest
{
    public class Person
    {
        private string firstName;
        private byte? age;

        // CONSTRUCTORS -----------------------------------------------------
        #region
        public Person()
            : this(null)
        {
        }

        public Person(string name)
            : this(name, null)
        {
        }

        public Person(string name, byte? age)
        {
            this.firstName = name;
            this.age = age;
        }
        #endregion

        // PROPERTIES -----------------------------------------------
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public byte? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // METHODS ----------------------------------------------------
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.firstName ?? "[Unnamed]", this.age != null ? this.age.ToString() : "[Unspecified]");
        }


    }
}

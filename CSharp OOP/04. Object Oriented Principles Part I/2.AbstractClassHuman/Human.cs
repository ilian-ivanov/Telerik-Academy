using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassHuman
{
    public abstract class Human
    {
        private readonly string firstName;
        private readonly string lastName;

        protected Human(string firstName, string lastName)
        {
            if (firstName != string.Empty && firstName.Length >= 2)
            {
                this.firstName = firstName;
            }
            else
            {
                throw new ArgumentException("The name can't be empty!");
            }

            if (lastName != string.Empty && lastName.Length >= 2)
            {
                this.lastName = lastName;
            }
            else
            {
                throw new ArgumentException("The name can't be empty!");
            }           
        }

        protected string FirstName
        {
            get { return this.firstName; }
        }

        protected string LastName
        {
            get { return this.lastName; }
        }

    }
}

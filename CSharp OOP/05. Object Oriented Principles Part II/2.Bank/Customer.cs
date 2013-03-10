using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class Customer
    {
        private TypeCustomer typeCustomer;
        private string name;

        // make two constructors. First is to enter only name and it will be always individual type
        public Customer(string name) : this(name, TypeCustomer.Individual)
        {
        }

        public Customer(string name, TypeCustomer type)
        {
            this.Name = name;
            this.typeCustomer = type;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name must be bigger than 1 character!");
                }
            }
        }

        public TypeCustomer TypeCustomer
        {
            get { return this.typeCustomer; }
            set { this.typeCustomer = value; }
        }

        public override string ToString()
        {
            return string.Format("Customer: {0}, Type: {1}.", this.name, this.typeCustomer);
        }
    }
}

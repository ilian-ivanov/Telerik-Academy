using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base (name, age, EnumGender.female)
        {
        }

        // in this way I make this property to be always female
        public EnumGender Sex
        {
            get { return base.Sex; }
            private set { }
        }

        public string AnimalSound()
        {
            return "Mrrr, mrrr!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base (name, age, EnumGender.male)
        {
        }

        // in this way I make this property to be always male
        public EnumGender Sex
        {
            get { return base.Sex; }
            private set { }
        }

        public string AnimalSound()
        {
            return "Miauuu, miauuu!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public Cat(string name, int age, EnumGender sex)
            : base(name, age, sex)
        {
        }

        public string AnimalSound()
        {
            return "Miau, miau!";
        }
    }
}

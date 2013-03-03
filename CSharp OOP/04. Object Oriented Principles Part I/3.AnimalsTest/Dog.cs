using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age)
            : base(name, age)
        {
        }

        public Dog(string name, int age, EnumGender sex)
            : base(name, age, sex)
        {
        }

        public string AnimalSound()
        {
            return "Bau, bau!";
        }
    }
}

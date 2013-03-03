using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age)
            : base(name, age)
        {
        }

        public Frog(string name, int age, EnumGender sex)
            : base(name, age, sex)
        {
        }

        public string AnimalSound()
        {
            return "Kva, kva!";
        }
    }
}

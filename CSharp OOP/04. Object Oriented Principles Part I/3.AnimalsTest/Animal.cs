using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    public class Animal
    {
        private int age;
        private EnumGender sex;
        private string name;

        // CONSTRUCTORS ---------------------------------------------------        
        public Animal(string name, int age)
            : this(name, age, EnumGender.male)
        {
        }
        
        public Animal(string name, int age, EnumGender sex)
        {
            this.Name = name;
            this.Age = age;
            this.sex = sex;
        }

        // PROPERTIES -----------------------------------------------------
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != string.Empty && value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The name can't be empty or only 1 character!");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("The age must be between 0 and 20 including!");
                }
            }
        }

        public EnumGender Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        // METHODS ------------------------------------------------------
        
        // here we check arrays with different animals in it
        public static IEnumerable<Tuple<string, double>> AverageAge(Animal[] animals)
        {
            var averageAges =
                from animal in animals
                group animal by animal.GetType() into animalType
                select new Tuple<string, double>(animalType.Key.Name, animalType.Average(a => a.Age));

            return averageAges;
        }               
    }
}

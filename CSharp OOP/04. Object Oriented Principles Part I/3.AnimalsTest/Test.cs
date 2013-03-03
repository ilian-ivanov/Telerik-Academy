using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalsTest
{
    class Test
    {
        static void Main()
        {
            Dog dog = new Dog("Emi", 1);

            Frog frog = new Frog("Ram", 3);
            
            Tomcat tomcat = new Tomcat("Tom", 5);

            Console.WriteLine("{0} say: {1}", tomcat.Name, tomcat.AnimalSound());
                                                  
            Console.WriteLine("{0} say: {1}", dog.Name, dog.AnimalSound());
                         
            Console.WriteLine("{0} say: {1}", frog.Name, frog.AnimalSound());
            
            Animal[] animals = 
            {
                 new Dog("Balkan", 3),
                 new Dog("asd", 2), 
                 new Dog("asd", 11),
                 new Dog("asd", 0), 
                 new Dog("asd", 18), 
                 new Dog("asd", 7), 
                 new Dog("asd", 5),
                 new Kitten("Kitty", 3), 
                 new Kitten("Kit", 7),
                 new Frog("Ram", 3)
            };

            var averageAges = Animal.AverageAge(animals);

            foreach (var typeAnimal in averageAges)
            {
                Console.WriteLine("Animal: {0} with average age: {1:F2}.", typeAnimal.Item1, typeAnimal.Item2);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Program
    {

        

    static void Main(string[] args)
        {
            var listAnimals = new List<Animal>();

            listAnimals.Add(new Frog("Broscuta", 3, "Male"));
            listAnimals.Add(new Frog("Broscuta2", 3, "Male"));
            listAnimals.Add(new Dog("Bobby", 5, "Male"));
            listAnimals.Add(new Cat("Pisi", 1, "Female"));
            listAnimals.Add(new Tomcat("Pisoi", 2, "Male"));
            listAnimals.Add(new Kittens("Pisicuta", 4, "Male"));

            //AverageAgeAnimals(listAnimals);

            //AverageAgeDogsCatsFrogs(listAnimals);

            //AverageAgeFrog(listAnimals);

            //AverageAgeDog(listAnimals)

            Console.WriteLine($"Average age for all animals: {AverageAgeAnimals(listAnimals)}");
            Console.WriteLine($"Average age for frogs: {AverageAgeFrog(listAnimals)}");
            Console.WriteLine($"Average age for dogs : { AverageAgeDog(listAnimals)}");
            Console.WriteLine($"Average age for cats: { AverageAgeCat(listAnimals)}");

            Console.ReadKey();

            

        }

        private static double AverageAgeCat(List<Animal> listAnimals)
        {
            double animalAge = 0;
            int count = 0;

            foreach (var animals in listAnimals)
            {
                if (animals.GetSound() == "Miau")
                {
                    animalAge = animalAge + animals.Age;
                    count++;
                }
            }
            return animalAge / count;
        }

        private static double AverageAgeDog(List<Animal> listAnimals)
        {
            double animalAge = 0;
            int count = 0;

            foreach (var animals in listAnimals)
            {
                if (animals.GetSound() == "Ham")
                {
                    animalAge = animalAge + animals.Age;
                    count++;
                }
            }
            return animalAge / count;
        }

        private static double AverageAgeFrog(List<Animal> listAnimals)
        {
            double animalAge = 0;
            int count = 0;

            foreach (var animal in listAnimals)
            {
                if (animal.GetSound() == "Croak")
                {
                    animalAge = animalAge + animal.Age;
                    count++;
                }
                
            }
            return animalAge/count;
        }

        private static void AverageAgeDogsCatsFrogs(List<Animal> listAnimals)
        {
            int animalAge = 0;
            int count = 0;
            foreach (var animal in listAnimals)
            {
                switch (animal.GetSound())
                {
                    case "Croak":
                        animalAge = animalAge + animal.Age;
                        break;
                    case "Ham":
                        animalAge = animalAge + animal.Age;
                        break;
                    case "Miau":
                        animalAge = animalAge + animal.Age;
                        break;
                    default:
                        animalAge = 0;
                        break;
                        
                }
                count++;




            }
            Console.WriteLine("Average age f:" + animalAge/count );
        }

        private static double AverageAgeAnimals(List<Animal> listAnimals)
        {
            double animalAge = 0;
            int count = 0;
            foreach (var animal in listAnimals)
            {

                animalAge = animalAge + animal.Age;

                count++;
            }
            return animalAge / count;
        }
    }
}

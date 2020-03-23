using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pet1 = new Animal("Sam");
            Cat pet2 = new Cat("Bob");
            Dog pet3 = new Dog();
            int happynessDefiner;

            Console.WriteLine("{0} is {1}", pet1.Name, pet1.Gender);
            Console.WriteLine("Enter a number relating to the happyness of {0}", pet1.Name);
            int.TryParse(Console.ReadLine(), out happynessDefiner);
            Console.WriteLine(pet1.MakeNoise(happynessDefiner));

            Console.WriteLine("{0} is {1}", pet2.Name, pet2.Gender);
            Console.WriteLine("Enter a number relating to the happyness of {0}", pet2.Name);
            int.TryParse(Console.ReadLine(), out happynessDefiner);
            Console.WriteLine(pet2.MakeNoise(happynessDefiner));

            Console.WriteLine("{0} is {1}", pet3.Name, pet3.Gender);
            Console.WriteLine("Enter a number relating to the happyness of {0}", pet3.Name);
            int.TryParse(Console.ReadLine(), out happynessDefiner);
            Console.WriteLine(pet3.MakeNoise(happynessDefiner));


            Console.ReadKey();

        }

    }
}

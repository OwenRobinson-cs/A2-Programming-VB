using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs3
{
    class Animal
    {
        private string name;
        private string gender;

        public string Name
        {
            get
            {
                return name;
            }

        }

        public string Gender
        {
            get { return gender; }

        }

        public Animal()
        {
            SetGender();
            NameAnimal(name);
        }
        public Animal(string _name)
        {
            SetGender();
            name = _name;
        }

        virtual public void NameAnimal(string _name)
        {
            name = Console.ReadLine();
        }

        virtual public string MakeNoise(int happynessDefiner)
        {
            if (happynessDefiner < 5) { return "Unhappy Gurgle"; }
            else { return "Gurgle"; }
        }

        private void SetGender()
        {
            Random rnd = new Random(216);
            if (rnd.Next(0, 500) % 2 == 1)
            {
                this.gender = "male";
            }
            else
            {
                this.gender = "female";
            }
        }
    }
    class Cat : Animal
    {
        public Cat()
            : base()
        {

        }
        public Cat(string name)
            : base(name)
        {

        }

        public override void NameAnimal(string _name)
        {

            Console.WriteLine("What is the name of your cat?");

            base.NameAnimal(_name);
        }
        new public string MakeNoise(int happynessDefiner)
        {
            if (happynessDefiner < 5) { return "Hiss"; }
            else { return "Meow"; }
        }
    }

    class Dog : Animal
    {
        public Dog()
            : base()
        {

        }
        public Dog(string name)
            : base(name)
        {

        }

        public override void NameAnimal(string _name)
        {

            Console.WriteLine("What is the name of your dog?");

            base.NameAnimal(_name);
        }
        new public string MakeNoise(int happynessDefiner)
        {
            if (happynessDefiner < 5) { return "Growl";  }
            else { return "Bark";  }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    internal class Boar : Beast
    {
        string diet;
        public Boar(string C_Name, string C_Animal, int C_Age, bool C_Predator) : base(C_Name, C_Animal, C_Age, C_Predator)
        {
            this.diet = "plants";
            this.sound = "snorts";
            this.movement = "run, tackle, fart.";

        }
        //public override void makeSound()
        //{
        //    Console.WriteLine(name + " grunts!");
        //}

        public void Diet()
        {
            Console.WriteLine("The {0} eats {1}.", animal, diet);
        }

    }
}

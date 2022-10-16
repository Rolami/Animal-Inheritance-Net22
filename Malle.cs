using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    internal class Malle : Wolf
    {
        private string job;
        public Malle(string C_Name = "Bubben", string C_Animal = "Dog", int C_Age = 4, bool C_Predator = true) : base(C_Name, C_Animal, C_Age, C_Predator)
        {
            this.sound = "growls";
            this.job = "drug sniffer";
            this.movement = "run, search, bite.";
        }

        public void Employment()
        {
            Console.WriteLine("The " + animal + " is employed as a" + job);
        }

    }
}

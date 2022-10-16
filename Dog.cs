using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    internal class Dog : Beast
    {
        string toy;
        public Dog(string C_Name, string C_Animal, int C_Age, bool C_Predator) : base(C_Name, C_Animal, C_Age, C_Predator)
        {
            this.sound = "barks wildly!";
            this.toy = "ball";
            this.movement = "run, sniff, cuddle.";

        }
        public void Play()
        {
            Console.WriteLine(name + " is playing with a " + toy);
        }
    }
}

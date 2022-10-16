using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    internal class Fennec : Wolf
    {
        private string special;
        public Fennec(string C_Name = "Spencer", string C_Animal = "Fennec Fox", int C_Age = 4, bool C_Predator = true) : base(C_Name, C_Animal, C_Age, C_Predator)
        {
            this.sound = "screams";
            this.special = "run in a circle creating a dust cloud!";
            this.movement = "dash, search, listen.";
        }

        public void Sandstorm()
        {
            Console.WriteLine("The " + animal + " can " + special);
        }

    }
}

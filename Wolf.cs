using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    internal class Wolf : Beast
    {
        private string prey;
        public Wolf(string C_Name = "Fenris", string C_Animal = "Wolf", int C_Age = 20000, bool C_Predator = true) : base(C_Name, C_Animal, C_Age, C_Predator)
        {
            this.sound = "howls";
            this.prey = "rabbit";
            this.movement = "run, stalk, dig.";

        }

        public void Hunt()
        {
            Console.WriteLine(name + " is out hunting " + prey);
        }
    }
}

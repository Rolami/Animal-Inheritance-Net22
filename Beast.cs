using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    public class Beast
    {
      //init variables
        protected string name;
        protected string animal;
        protected string movement;
        protected bool predator;
        protected int age;
        protected string sound;

        public Beast(string C_Name, string C_Animal, int C_Age, bool C_Predator)
        {
            name = C_Name;
            animal = C_Animal;
            age = C_Age;
            predator = C_Predator;
            this.sound = "The animal makes a sound!";

        }
        public void Move() //#1
        {
           
            Console.WriteLine("The " + animal + " can " + movement);
        
        }

        public virtual void makeSound()
        {
            //Console.WriteLine("The animal makes a sound!");
            Console.WriteLine(name + " " + sound + "!");
        }

        public void Presentation()
        {

            Console.WriteLine(name + " is a " + age + " years old " + animal + ".");
            if (predator == true)
            {
                Console.WriteLine(name + " is a predator that hunts prey.");
            }
            else
            {
                Console.WriteLine(name + "is a prey that gets hunted by predators.");
            }

        }

    }


}




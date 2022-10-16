namespace Animal_Inheritance
{

    //Robin Larsson - NET 22 - OOP 6
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dog dog1 = new Dog("Fido", "Dog", 5, true);
            //dog1.makeSound();
            //dog1.Play();
            //dog1.Presentation();
            //dog1.Move();
            //Console.WriteLine();

            //Wolf wolf1 = new Wolf();
            //wolf1.makeSound();
            //wolf1.Hunt();
            //wolf1.Presentation();
            //wolf1.Move();
            //Console.WriteLine();

            //Wolf wolf2 = new Wolf(C_Name: "Silver Fang", C_Age: 15);
            //wolf2.makeSound();
            //wolf2.Hunt();
            //wolf2.Presentation();
            //wolf2.Move();
            //Console.WriteLine();

            //Wolf wolf3 = new Wolf("Loki",C_Age: 10);
            //wolf3.makeSound();
            //wolf3.Hunt();
            //wolf3.Presentation();
            //wolf3.Move();
            //Console.WriteLine();


            //Boar boar1 = new Boar("Pumba", "Boar", 3, false);

            //boar1.makeSound();
            //boar1.Diet();
            //boar1.Presentation();
            //boar1.Move();
            //Console.WriteLine();

            Malle malle1 = new Malle();
            malle1.makeSound();
            malle1.Employment();
            malle1.Presentation();
            malle1.Move();
            Console.WriteLine();

            Fennec fennec1 = new Fennec();
            fennec1.makeSound();
            fennec1.Sandstorm();
            fennec1.Presentation();
            fennec1.Move();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}

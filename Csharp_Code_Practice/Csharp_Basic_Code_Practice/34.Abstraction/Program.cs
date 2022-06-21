using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Abstraction*******************");
            //Dog object
            Dog dog = new Dog();
            dog.animalSound();
            dog.sleep();
        }
    }
}

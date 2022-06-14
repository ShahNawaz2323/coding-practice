using System;

namespace Interfaces
{
    interface IAnimal
    {
        void animalSound();
    }

    class Dog : IAnimal
    {
        public void animalSound()
        {
            System.Console.WriteLine("The Dog Says : wow wowo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.animalSound();
        }
    }
}

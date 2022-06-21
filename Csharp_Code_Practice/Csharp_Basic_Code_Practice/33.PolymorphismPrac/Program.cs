using System;

namespace PolymorphismPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal wolf = new Wolf();
            Animal dog  = new Dog();

            animal.animalSound();
            wolf.animalSound();
            dog.animalSound();
        }
    }
}

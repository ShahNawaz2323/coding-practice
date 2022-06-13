using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************Classes Inheritance***************");
            Car car = new Car();

            //Parent class honk() method call
            car.honk();

            //using object acces field of child and parent class
            System.Console.WriteLine(car.brand + " " + car.modelName );

        }
    }
}

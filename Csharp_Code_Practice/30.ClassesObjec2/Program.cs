using System;

namespace ClassesObjec2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Classes and objects multiple paarameters*************");
            Cars car = new Cars("Mustang", "Red", 1969);
            // System.Console.WriteLine(car.color + " " + car.year+ " " + car.model);

            Person myObj = new Person();
            myObj.Name = "ShahNawaz";
            System.Console.WriteLine(myObj.Name);

        }
    }
}

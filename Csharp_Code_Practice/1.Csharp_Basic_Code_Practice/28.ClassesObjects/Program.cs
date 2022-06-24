using System;

namespace ClassesObjects
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("********************Classes and Objects*************");
            Cars ford = new Cars();
            ford.model = "Mustang";
            ford.color = "red";
            ford.year = 1969;

            var Opel = new Cars();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            System.Console.WriteLine(ford.model);
            System.Console.WriteLine(Opel.model);
            ford.fullThrottle();
            System.Console.WriteLine("Ford Top Speed : " + ford.topspeed);
           
           
            // Program myobj = new Program();
            // System.Console.WriteLine(myobj.color);
            // Program myobj1 = new Program();
            // System.Console.WriteLine(myobj1.color);
        }
    }
}

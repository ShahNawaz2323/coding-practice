using System;

namespace DataTypes
{
    public class radius
        {
            public void radiusCal()
            {
                Console.WriteLine("*****Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.*****\n");
            float r;
            float pi = 3.1415926535f;
            float result ;

            System.Console.Write("Radius: ");
            r = Convert.ToUInt32(Console.ReadLine());

            result = 4 * pi * (r * r); 
            System.Console.WriteLine($"Area of a Sphere : {result}");

            result = 4f/3f * pi * (r * r * r); 
            System.Console.WriteLine($"Volume of a Sphere : {result}");
            }
        }
}

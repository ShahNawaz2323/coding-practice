using System;


namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Image_Width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image_height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientationLP.Landscape : ImageOrientationLP.Potrait ;
            System.Console.WriteLine("Image Orientation is : " + orientation);
        }
    }
}
public enum ImageOrientationLP
{
    Landscape,
    Potrait
}

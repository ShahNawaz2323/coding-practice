using System;
namespace CS2
{
    public class Height
    {
    //    float PerHeight;
       public float PerHeight { get; set; }
        public void height_finder()
        {
            
            Console.Write("\n\n");
            Console.Write("Accept the height of a person in centimeter and categorize them:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the height of the person (in centimetres):");
            PerHeight = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(PerHeight);

            Heightcalculator();
        }
        public void Heightcalculator()
        {
            if (PerHeight < 150.0)
            {
                System.Console.WriteLine("The Person is Dwarf.\n\n");
            }
            else if((PerHeight >= 150) && (PerHeight <= 165.0))
            {
                System.Console.WriteLine("The person is  average heighted. \n\n");
            }
            else if((PerHeight >= 165.0) && (PerHeight <= 195.0))
            {
                Console.Write("The person is taller. \n\n");
            }
            else
                Console.Write("Abnormal height.\n\n");
        }
    }
}

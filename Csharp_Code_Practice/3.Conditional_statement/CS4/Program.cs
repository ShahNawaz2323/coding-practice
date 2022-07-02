using System;

namespace CS4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n *****Write a C# Sharp program to find the eligibility of admission for a professional course*****\n");
            int Math, Phy, Chem;

            Console.Write("Eligibility Criteria :\n");
            Console.Write("Marks in Maths >=65\n");
            Console.Write("and Marks in Phy >=55\n");
            Console.Write("and Marks in Chem>=50\n");
            Console.Write("and Total in all three subject >=180\n");
            Console.Write("or Total in Maths and Physics >=140\n");
            Console.Write("-------------------------------------\n");

            System.Console.Write("Input The Marks obtained in the Physics : ");
            Phy = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input The Marks obtained in the Chemistry : ");
            Chem = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input The Marks obtained in the Math : ");
            Math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", Math + Phy + Chem);
            Console.Write("Total marks of Maths and  Physics : {0}\n", Math + Phy);

            if (Math >= 65)
            {
                if (Phy >= 55)
                {
                    if (Chem >= 50)
                    {
                        if ((Math + Phy + Chem) >= 180 || (Math + Phy) >= 140)
                        {
                            System.Console.WriteLine("The candidate is eligible for admission.\n");
                        }
                        else
                        {
                            System.Console.WriteLine("The Candidate is not eligible.\n\n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("The Candidate is not eligible.\n\n");
                    }

                }
                else
                {
                    System.Console.WriteLine("The Candidate is not eligible.\n\n");
                }
            }
            else
            {
                System.Console.WriteLine("The Candidate is not eligible.\n\n");
            }


        }
    }
}

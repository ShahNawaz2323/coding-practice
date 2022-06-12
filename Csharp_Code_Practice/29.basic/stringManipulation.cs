using System;

namespace basic
{
    public class stringManipulation
    {
        public void Method1()
        {
            Console.WriteLine("Write a C# program to check if \"HP\" appears at second position in a string and returns the string without \"HP\" ");
            System.Console.Write("Please give Input \"PHP Tutorial\" : ");
            string input = Console.ReadLine();
            
            System.Console.WriteLine((input.Substring(1,2).Equals("HP")?input.Remove(1,2) : input));
            if  (input.Substring(1,2).Equals("HP"))
            {
                string str  = input.Remove(1,2);
                System.Console.WriteLine(str);
                System.Console.WriteLine("if statm is running");
            }
            else
            {
                System.Console.WriteLine(input);
                System.Console.WriteLine("Else stamt is running.");
            }

        }
    }
}

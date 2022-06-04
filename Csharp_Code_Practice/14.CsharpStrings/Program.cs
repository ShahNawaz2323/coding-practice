using System;

namespace CsharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************CSharp Strings****************");
            string greeting = "Hello World";
            System.Console.WriteLine(greeting);
            System.Console.WriteLine("The Length of the string is : " + greeting.Length);
            System.Console.WriteLine(greeting.ToUpper());
            System.Console.WriteLine(greeting.ToLower());

            string firstName = "John";
            string lastName = " Shah";
            string name = firstName + lastName;
            System.Console.WriteLine(name);

            System.Console.WriteLine("****Concatenation of strings**************");
            string firstName1 = "John";
            string lastName2 = " Shah";
            string name1 = string.Concat(firstName1,lastName2);
            System.Console.WriteLine(name1);

            System.Console.WriteLine("********************$sign concatenation************");
            string name2 = $"My full name is not: {firstName} {lastName}";
            System.Console.WriteLine(name2);

            System.Console.WriteLine("**********String Access By index****************");
            string myString = "Iqbal";
            System.Console.WriteLine(myString[0]);

            System.Console.WriteLine("**********Check index****************");
            System.Console.WriteLine(myString.IndexOf("b"));
            System.Console.WriteLine(myString.IndexOf("I"));

            System.Console.WriteLine("**********Mske Substring****************");
            int substr = myString.IndexOf("b");
            string lastName3 = myString.Substring(substr);
            System.Console.WriteLine(lastName3); 

            System.Console.WriteLine("**********quotes in strings****************");
            string txt = "We are the so called \"Vikings\" from the north.";
            string txt2 = "Thonas is a \"MadTitan\".";
            System.Console.WriteLine(txt);
            System.Console.WriteLine(txt2);
        }

    }
}

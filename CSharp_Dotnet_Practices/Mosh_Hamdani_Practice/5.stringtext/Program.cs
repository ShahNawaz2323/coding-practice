using System;

namespace stringText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************String Text Manipulation**************");
            var fullName = "Mosh Hamedani ";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            Console.WriteLine("*******************IndexOf**************");
            var index = fullName.IndexOf(' ');
            System.Console.WriteLine("index: " + index);

            var firstName = fullName.Substring(0 , index);
            var LastName = fullName.Substring(index + 1);
            System.Console.WriteLine("FirstName: " + firstName);
            System.Console.WriteLine("LastName: " + LastName);

            Console.WriteLine("*******************Split()**************");
            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: " + names[0]);
            System.Console.WriteLine("LastName: " +  names[1] );

            Console.WriteLine("***********Replace and other methods*********");
            System.Console.WriteLine(fullName.Replace("Mosh", "Hafiz"));
            System.Console.WriteLine(fullName.Replace("Hamedani", "Shah"));

            Console.WriteLine("***********Work With Empty Strings and Null*********\n");
            System.Console.WriteLine("Case01: ");
            if (String.IsNullOrEmpty(null))
            {
                System.Console.WriteLine("Invalid");
            }
            if (String.IsNullOrEmpty(""))
            {
                System.Console.WriteLine("Invalid");
            }
            System.Console.WriteLine("\nCase02: ");
            if (String.IsNullOrWhiteSpace(" "))
            {
                System.Console.WriteLine("Invalid");
            }
            else
            {
                System.Console.WriteLine("Valid");
            }
            
            Console.WriteLine("\n***********Input Validation + Conversion*********\n");
            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine("age: " + age);

            float price = 17.90f;
            System.Console.WriteLine("Simple Currency: " + price.ToString("C"));
            System.Console.WriteLine("Currency with no decimak: " + price.ToString("C0"));
            System.Console.WriteLine("Currency with one decimal point: " + price.ToString("C1"));

        }
    }
}

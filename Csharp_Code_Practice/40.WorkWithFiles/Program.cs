using System;
using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Working With Files**************************");
            string writeText = "Hello World this is the string file going to save in file"; //Create a text string
            File.WriteAllText("D://filename.txt", writeText);
            System.Console.WriteLine("File Printed on the hard and saved \n");

            System.Console.WriteLine("\n Reading the text.......");
            string readText = File.ReadAllText("D://filename.txt"); //read the contents of the file
            System.Console.WriteLine(readText);



        }
    }
}

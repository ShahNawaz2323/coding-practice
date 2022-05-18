using System;
using System.IO;

namespace WorkwithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************Working With Strings********************");
            var path = @"c:\somefiles.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            if (File.Exists(path))
            {
                //some logic
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //some code goes here.
            }
        }
    }
}

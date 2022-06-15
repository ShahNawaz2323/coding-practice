using System;

namespace MultiInterfaces
{
    public enum level
    {
        Low,
        Medium,
        High
    }
    interface ImyFirstInterface
    {
        void myMethod();
    }
    interface ImySecondInterface
    {
        void myOtherMethod();
    }
    //implement multiple Interface
    class DemoClass : ImyFirstInterface, ImySecondInterface
    {
        public void myMethod()
        {
            System.Console.WriteLine("Interface First Method implementention ");
        }

        public void myOtherMethod()
        {
            System.Console.WriteLine("Second Interface implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Multi-level interfacee");
            // DemoClass myObj = new DemoClass();
            // myObj.myMethod();
            // myObj.myOtherMethod();
            System.Console.WriteLine("Enum practice: ");
            level myLevel = level.Low;
            System.Console.WriteLine("You point is: {0}",myLevel);
        }
    }
}

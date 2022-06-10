using System;

namespace MethodPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Methods*************");
            Method1 method1 = new Method1();
            //method overloading
            int myNum = method1.PlusMethod(8,5);
            double myNum2 = method1.PlusMethod(8.5,5.6);
            System.Console.WriteLine("Int: " + myNum);
            System.Console.WriteLine("Double: " +  myNum2);
            // method1.MyMethod4("ShahNawaz", 28);
            // method1.MyMethod4("Ustad", 20);
            // method1.MyMethod4("Gul Ahamd", 35);     
            
            // int z = method1.MyMethod5(3);
            // System.Console.WriteLine(z);
            
            // int z = method1.MyMethod6(3,4);
            // System.Console.WriteLine(z);

            //method1.MyMethod7(child1: "Shah", child3: "Umar", child2: "Ustad");
            // method1.MyMethod();
            // System.Console.WriteLine("Methods call Multiple time: ");
            // MyMethod1();
            // MyMethod1();
            // MyMethod1();
            // System.Console.WriteLine("Method With Parameters: ");
            // MyMethod2("Liam");
            // MyMethod2("Jenny");
            // MyMethod2("Anja");

            // //default value and value assign
            // method1.MyMethod3("Pakistan");
            // method1.MyMethod3("Iran");
            // method1.MyMethod3();
            // method1.MyMethod3("Afg");
        }

        // static void MyMethod1()
        // {
        //     System.Console.WriteLine("Method excuted");
        // }

        // static void MyMethod2(string fname)
        // {
        //     System.Console.WriteLine(fname + " Refsnes");
        // }
    }
}

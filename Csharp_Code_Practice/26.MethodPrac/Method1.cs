namespace MethodPrac
{
    public class Method1
    {
        public void MyMethod()
        {
            System.Console.WriteLine("I just go executed!");
        }

        public void MyMethod3(string country = "Egypt")
        {
            System.Console.WriteLine(country);
        }

        public void MyMethod4(string name , int age)
        {
            System.Console.WriteLine(name + " is " + age);
        }

        //return method
        public int MyMethod5(int x)
        {
            return 5 + x; 
        }

        public int MyMethod6(int x, int y)
        {
            return y + x; 
        }

        public void MyMethod7(string child1, string child2, string child3)
        {
            System.Console.WriteLine("the youngest child is: " + child3);
        }

        //Method Overloading
        public  int PlusMethod(int x, int y)
        {
            return x + y;
        }

        public double PlusMethod(double x,double y)
        {
            return x + y;
        }

    }
}

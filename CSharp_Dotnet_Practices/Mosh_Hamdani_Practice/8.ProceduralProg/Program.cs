using System;


namespace ProceduralProg
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your Name: ");
            var name = Console.ReadLine();
            var reversed = ReversedName(name);
            System.Console.WriteLine("Reversed Name: " + reversed);
        }
        public static string ReversedName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length -i] = name[i - 1];
            }

            return new string(array);

        }
    }
}

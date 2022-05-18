namespace PropertiesPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new System.DateTime(1994,02,10);
            System.Console.WriteLine(person.Age);
        }
    }
}

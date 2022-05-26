namespace ConstructorInheri
{
    public class Car : Vehicle
    {
        public Car( string registrationNumber) : base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialised. {0}", registrationNumber);
        }
    }
}

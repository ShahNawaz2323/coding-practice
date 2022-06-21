namespace ClassesObjects
{
    public class Cars
    {
        public string model { get; set; }
        public string color { get; set; }
        public int year { get; set; }

        public string topspeed {get; set;}

        public Cars()
        {
            topspeed = "550kmh";
        }


        public void fullThrottle()
        {
            System.Console.WriteLine("The car is going as fast as it can!");
        }
    }
}

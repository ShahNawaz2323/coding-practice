namespace ClassesObjec2
{
    public class Cars
    {
        public string model { get; set; }
        public string color { get; set; }
        public int year { get; set; }

        //Cars Constructor with multiple parameters
        public Cars(string ModelName, string ModelColor, int ModelYear)
        {
            model = ModelName;
            color = ModelColor;
            year = ModelYear;
        }
    }
}

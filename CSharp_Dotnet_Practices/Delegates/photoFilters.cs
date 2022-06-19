namespace Delegates
{
    public class photoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Resize Photo");
        }
    }
}

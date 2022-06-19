namespace Delegates
{
    public class photoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new photoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}

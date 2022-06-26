using System.Threading;   
namespace Delegtes
{
    public class VideoEncoder
    {
        public void Encode (Video video)
        {
            System.Console.WriteLine("Encoding Video......");
            Thread.Sleep(3000);
        }
    }
}

using System;
namespace Delegtes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Events and Delegates***********");
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }
    }
}

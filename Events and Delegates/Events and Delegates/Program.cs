using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.Title = "Alien Covenent";
            VideoEncoder videoencoder = new VideoEncoder();//publisher
            MailService mailService = new MailService();//subscriber
            videoencoder.videoEncoded = mailService.OnvideoEncoded;//a pointer reference to the 
            videoencoder.encode(video);
            Console.ReadKey();
        }
    }
}

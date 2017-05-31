using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.Title = "Alien Covenant";
            VideoEncoder videoEncoder = new VideoEncoder();// publisher
            MailService mailSerivice = new MailService();// Subscriber;
            
            
            
            videoEncoder.videoEncoded += mailSerivice.OnVideoEncoded;// pointer /references to the method
           
            MessageService messageService = new MessageService(); // Another subscriber

            videoEncoder.videoEncoded += messageService.OnVideoEncoded;
            
            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}

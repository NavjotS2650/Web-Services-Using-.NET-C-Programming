using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_delegates
{
    class MailService
    {
        //We want the method to match the delegate signatures
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mail Service is Working");
        }
    }
}

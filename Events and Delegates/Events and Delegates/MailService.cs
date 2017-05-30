using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    class MailService
    {
        //we want the method tto match the delegate signature
        public void OnvideoEncoded(object source, EventArgs)
        {
            Console.WriteLine("mailservice is working");
        }
    }
}

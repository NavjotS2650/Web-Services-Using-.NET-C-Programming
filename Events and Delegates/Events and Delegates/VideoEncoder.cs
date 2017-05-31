using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events_and_delegates
{
    class VideoEncoder
    {
        /*Now we want to implement an event in VideoEncoder
         * Such that when the encoding os finished , it notifies any one interested in event
         * */
        //1. Define a delegate
        //2. deifine an event based on that delegate
        //3. raise the event


        //Create our delegate
        // Delegate is a pointer or references to the method below
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);
        
        //2 now lets create an event 
        public event VideoEncoderEventHandler videoEncoded;
        


        public void Encode(Video video)
        {
           
            Thread.Sleep(3000);
            Console.WriteLine("Encoding a Video: ");
            OnVideoEncoded();//3. Raising the event
            //notifiiying all subscribers 
        }

        protected virtual void OnVideoEncoded()
        {
            if (videoEncoded !=null) //if null -> no subscribers
            {
                videoEncoded(this, EventArgs.Empty);// this calls the subscribers
            }                                       // and passes 2 arguments
            // this -> refers to the current
            // EventArgs.Empty -> we are not sending additional info to the subscribers
        }
    }
}

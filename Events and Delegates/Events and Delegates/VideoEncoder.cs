using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Events_and_Delegates
{ /*now we want to implement an event in videoencoder 
    *such that when the encloading is finished, it notifies anyone interested in the event.
    */

    //1.define a delegate.
    //2. define an event based on that delegate.
    //3. raise the event.

    // 1. create ou delegate
    //the delegate is a pointer /reference to the methodd below
    public delegate void VideoEncoderEventHandler(object source, EventArgs args);

    //2. lets creates an event
    public event VideoEncoderEventHandler VideoEncoded;

    class VideoEncoder
    {
       public void encode(Video video)
        {
            Thread.Sleep(2000);
            Console.WriteLine("the sleep videoencoder");
            OnVideoEncoded();//3 raising the event notifyinf all the subscribers

        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoder != null)//if null,=> subscribers;
                VideoEncoder(this, EventArgs.Empty);//this calls th esubscroibwers
            //this=>refers 5o the current
            //eventargs.empty=>

        }
    }
}

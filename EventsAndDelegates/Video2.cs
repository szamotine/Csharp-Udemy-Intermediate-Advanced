using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Intermediate_Udemy.EventsAndDelegates
{
    public class Video2
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video2 Video { get; set; }
    }

    public class VideoEncoder2
    {
        //3 Steps to publish an event:
        
        //1 - define a delegate
       //public delegate void VideoEncodedHandler(object source, VideoEventArgs args);
        
        //2 - define an event based on that delegate
        //public event VideoEncodedHandler VideoEncoded;

        // this replaces step 1 and 2 using a generic handler instead of a custom handler
        public event EventHandler<VideoEventArgs> VideoEncoded;
        

        public void Encode(Video2 video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);

        }
        
        //3 - raise the event
        protected virtual void OnVideoEncoded(Video2 video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video });
            }
            else
            {
                Console.WriteLine("No subscribers to VideoEncoded()");
            }
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService sending an email..." + e.Video.Title);
        }
    }

    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("SMS Service sending a text..." + e.Video.Title);
        }
    }
}

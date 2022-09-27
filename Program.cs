using Csharp_Intermediate_Udemy.Delegates;
using System;

namespace Csharp_Intermediate_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Post
            /*
            var p = new Post();

            while (true)
            {
                Console.WriteLine("Would you like to upvote or downvote? Enter up or down.");
                string command = Console.ReadLine();
                if (command.Equals("up"))
                {
                    p.upVote();
                    
                }
                if (command.Equals("down"))
                {
                    p.downVote();
                }

            }
            */
            #endregion

            #region Stopwatch
            /*
             var sw = new Stopwatch();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter stop or start command");
                    String command = Console.ReadLine();
                    if (command.Equals("stop"))
                    {
                        sw.stop();
                    }
                    if (command.Equals("start"))
                    {
                        sw.start();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
            */
            #endregion

            #region Stack
            /*
            var stack = new Stack();
            stack.Push(1);
           // stack.display();
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            */
            #endregion

            #region Video Encoder
            /*
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
            */
            #endregion

            #region Workflow
            /*
            var workflow = new Workflow();
            var workflow2 = new Workflow();
            var engine = new WorkflowEngine();

            engine.Run(workflow);
            engine.Run(workflow2);
            */
            #endregion

            #region PhotoProcessor
            /*
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            //PhotoProcessor. filterHandler = filters.ApplyBrightness; -> uses custom delegate, replaced by generic

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;

            processor.Process("path", filterHandler);
            */

            #endregion




        }
    }

}

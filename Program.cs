using Csharp_Intermediate_Udemy.Delegates;
using Csharp_Intermediate_Udemy.EventsAndDelegates;
using LINQ;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

            #region Events and Delegates
            /*
            var video = new Video2() { Title = "Video 1" };
            var videoencoder = new VideoEncoder2();     //publisher
            var mailService = new MailService();        //subscriber
            var smsService = new SmsService();          //subscriber

            videoencoder.VideoEncoded += mailService.OnVideoEncoded;
            videoencoder.VideoEncoded += smsService.OnVideoEncoded;

            videoencoder.Encode(video);
            */
            #endregion

            #region Extension Methods
            /*
            var str = "this is a really long string that goes on and on and never really ends...";
            Console.WriteLine(str.Shorten(-1));
            */
            #endregion

            #region LINQ

            //var books = new BookRepository().GetBooks();

            ////without LINQ
            //var cheapBooks = new List<Book>();
            //foreach(var b in books)
            //{
            //    if (b.Price < 10) cheapBooks.Add(b);
            //}


            //LINQ Extension Method

            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderByDescending(b => b.Price)
            //                    .Select(b => b.Title);



            /*
            //LINQ Query Operators
            var cheapBooks = from b in books
                             where b.Price < 10
                             orderby b.Title
                             select b;

            Console.WriteLine("Cheap books:");
            foreach (var b in cheapBooks) Console.WriteLine("Title: {0}, \t Price: {1}", b.Title, b.Price);
            */
            #endregion

            #region Nullable Types
            /*
            DateTime? date = null;
            DateTime date2;

            //longer method
            if(date != null)
            {
                date2 = date.GetValueOrDefault();
            }
            else
            {
                date2 = DateTime.Today;
            }

            //Null Coalescing Operator

            DateTime date3 = date ?? DateTime.Today;



            Console.WriteLine(date2);
            */
            #endregion



        }
    }
}

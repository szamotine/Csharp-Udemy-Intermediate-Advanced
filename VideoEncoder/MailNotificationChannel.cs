using System;
namespace Csharp_Intermediate_Udemy
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail... ");
        }
    }
}

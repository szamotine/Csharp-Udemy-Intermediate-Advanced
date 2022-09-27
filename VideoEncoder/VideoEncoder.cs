﻿using System.Collections.Generic;


namespace Csharp_Intermediate_Udemy
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video Video)
        {
            // Video encoding logic
            // ...
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}

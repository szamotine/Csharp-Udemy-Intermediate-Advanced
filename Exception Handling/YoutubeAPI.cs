using Csharp_Intermediate_Udemy;
using System.Collections.Generic;
using System;

namespace ExceptionHandling
{
    public class YoutubeAPI
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access Youtube web service
                //Read the data
                //Create a list of Video objects

            }
            catch (Exception ex)
            {
                //log

                throw new YoutubeException("Could not fetch the videos from youtube", ex);
            }

            return new List<Video>();
        }

    }
}
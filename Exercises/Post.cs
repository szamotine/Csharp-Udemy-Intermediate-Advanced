using System;

namespace Csharp_Intermediate_Udemy
{
    class Post
    {
        private string title;
        private string description;
        private DateTime creationDateTime;

        public int VoteCount { get; set; }

        public Post()
        {
            VoteCount = 0;
            creationDateTime = DateTime.Now;
        }
        public Post(string title, string description)
        {
            this.title = title;
            this.description = description;
            VoteCount = 0;
            creationDateTime = DateTime.Now;
        }

        public void upVote()
        {
            // voteCount++;
            Console.WriteLine("Vote count is now {0}", ++VoteCount);
        }
        public void downVote()
        {
            // voteCount--;
            Console.WriteLine("Vote count is now {0}", --VoteCount);
        }

    }
}

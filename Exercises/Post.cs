using System;

namespace Csharp_Intermediate_Udemy
{
    class Post
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDateTime { get; set; }

        public int VoteCount { get; set; }

        public Post()
        {
            VoteCount = 0;
            CreationDateTime = DateTime.Now;
        }
        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            VoteCount = 0;
            CreationDateTime = DateTime.Now;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Intermediate_Udemy
{
    class Post
    {
        private string title;
        private string description;
        private DateTime creationDateTime;
        private int voteCount;

        public Post()
        {
            voteCount = 0;
            creationDateTime = DateTime.Now;
        }
        public Post(string title, string description)
        {
            this.title = title;
            this.description = description;
            voteCount = 0;
            creationDateTime = DateTime.Now;
        }

        public void upVote()
        {
           // voteCount++;
            Console.WriteLine("Vote count is now {0}", ++voteCount);
        }
        public void downVote()
        {
           // voteCount--;
            Console.WriteLine("Vote count is now {0}", --voteCount);
        }

    }
}

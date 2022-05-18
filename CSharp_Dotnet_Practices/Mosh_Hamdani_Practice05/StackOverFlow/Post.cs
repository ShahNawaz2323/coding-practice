using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime {get; set;}
        public int Votes { get; set; }

        public void VoteUp()
        {
            Votes++;
        }
        public void VoteDown()
        {
            Votes--;
        }

        public void PrintFullPost()
        {
            System.Console.WriteLine("Date Posted: " + CreatedTime.ToLongDateString());
            System.Console.WriteLine(Title);
            System.Console.WriteLine();
            System.Console.WriteLine(Description);
            System.Console.WriteLine();
            System.Console.WriteLine("Votes: " + Votes);
        }
    }
}

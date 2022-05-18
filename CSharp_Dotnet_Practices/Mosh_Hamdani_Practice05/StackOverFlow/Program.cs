using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionPost = new Post();

            solutionPost.CreatedTime = new  DateTime(2015,12,21);

            solutionPost.VoteUp();
            solutionPost.VoteUp();
            solutionPost.VoteUp();
            solutionPost.VoteUp();

            System.Console.WriteLine("Should have 4 Votes: " + solutionPost.Votes);

            solutionPost.PrintFullPost();

            solutionPost.VoteDown();
            solutionPost.VoteDown();
             
            System.Console.WriteLine("Should have 2 Votes: " + solutionPost.Votes);

            solutionPost.PrintFullPost();

        }
    }
}

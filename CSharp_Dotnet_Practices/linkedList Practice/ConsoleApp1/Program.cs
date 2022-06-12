using System;
using ConsoleApp1.LinkedList;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkList lnk = new SimpleLinkList();
            lnk.AddLast("One");
            lnk.AddLast("two");
            lnk.AddLast("3");
            lnk.AddLast("4");
            lnk.AddFirst("First");
            lnk.ReadAll();
        }
    }
}

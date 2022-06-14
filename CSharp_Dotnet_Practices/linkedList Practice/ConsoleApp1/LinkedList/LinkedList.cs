using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LinkedList
{
    //This class will have the logic to connect the node objects to create link list structue
    public class SimpleLinkList
    {
        //start node of te linked list chain
        Node head = null;
        Node tail = null; 

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                head.Next = null;
            }
            else
            {
                Node current = head;
                //head = tail
                //loop and find the last node
                while (current.Next != null)
                {
                    current = current.Next;
                }
                //Console.WriteLine(tail);
                //null this means this is the last element or last node
                current.Next = newItem;
                newItem.Next = null;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            newItem.Next = head;
            head = newItem;

        }
        public void ReadAll()
        {
            Node current = head; 
            //loop until the last node
            while (current.Next != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }
            Console.WriteLine(current.data);  
        }
    }
}

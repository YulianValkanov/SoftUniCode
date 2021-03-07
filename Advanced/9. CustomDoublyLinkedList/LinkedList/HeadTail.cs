using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class HeadTail
    {


        int count = 0;

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void Foreach(HeadTail linkedList)
        {
            Node currentNode = linkedList.Head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public  int[] Array(HeadTail linkedList)
        {

            int[] array = new int[count];

            Node currentNode = linkedList.Head;

           

            int cc = 0;
            while (currentNode != null)
            {
                array[cc] = currentNode.Value;
                currentNode = currentNode.Next;
                cc++;
            }
            return array;
        }


        public void AddFirst(Node node)
        {
            count++;

            if (Head==null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previose = node;
                Head = node;      
            }    
        }
        public void AddLast(Node node)
        {

            count++;

            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Previose = Tail;
                Tail.Next = node;
                Tail = node;
            }
        }

        public Node RemoveFirst()
        {
            count--;
            if (Head==null)
            {
                return null;
            }


            var nodeToReturn = Head;
            if (Head.Next!=null)
            {
                Head = Head.Next;
                Head.Previose = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }


            return nodeToReturn;


        }

        public Node RemoveLast()
        {

            count--;
            var nodeToReturn = Tail;


            if (Tail.Previose!=null)
            {
                Tail = Tail.Previose;
                Tail .Next = null;
            }
            else
            {
                Tail = null;
                Head = null;
            }
            
           

            return nodeToReturn;



        }
    }
}

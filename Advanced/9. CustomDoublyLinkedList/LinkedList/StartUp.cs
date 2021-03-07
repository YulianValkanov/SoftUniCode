using System;

namespace LinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HeadTail linkedList = new HeadTail();

            for (int i = 1; i <= 10; i++)
            {
                linkedList.AddFirst(new Node(i));
            }

            for (int i = 1; i <= 10; i++)
            {
                linkedList.AddLast(new Node(i));
            }

           
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            linkedList.Foreach(linkedList);

            int[] currrr= linkedList.Array(linkedList);

            foreach (var item in currrr)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}

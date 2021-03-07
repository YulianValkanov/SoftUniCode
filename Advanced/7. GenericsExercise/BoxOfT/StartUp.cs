using System;

namespace BoxOfT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> elememts = new Box<int>();
          
            elememts.Add(1);
            elememts.Add(2);
            elememts.Add(2);
            Console.WriteLine(elememts.Count);
            Console.WriteLine( elememts.Remove());
            Console.WriteLine(elememts.Remove());
            Console.WriteLine(elememts.Count);

        
        }
    }
}

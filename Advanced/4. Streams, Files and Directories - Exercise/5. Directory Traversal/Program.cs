using System;
using System.IO;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Julian\Desktop\SoftUni C#\Advanced\";

            string[] fileNames = Directory.GetFiles(path);

            foreach (var item in fileNames)
            {
                FileInfo info = new FileInfo(item);
                string name = info.Name;
                string extension = info.Extension;
                double size = info.Length/1024;
                Console.WriteLine(extension);
                Console.WriteLine(name);
                Console.WriteLine(size);
            }
        }
    }
}

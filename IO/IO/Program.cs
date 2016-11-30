using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"D:\IO.txt"));
            Console.WriteLine(Directory.Exists(@"D:\"));

            string path = ".";//当前路径
            if (args.Length > 0)
            {
                if (Directory.Exists(args[0]))
                {
                    path=args[0];
                }
                else
                {
                    Console.WriteLine("{0} not found;using current direction:", args[0]);
                }
            }

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo f in dir.GetFiles("*.exe"))
            {
                string name = f.Name;
                long size = f.Length;
                DateTime creationTime = f.CreationTime;
                Console.WriteLine("{0,-12:N0}{1,-20:g}{2}", size, creationTime, name);
            }
        }
    }
}
using System;
using System.IO;

namespace IORead
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";

        static void Main(string[] args)
        {
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not esists", FILE_NAME);
                return;
            }

            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(r.ReadString());
            }

            r.Close();
            fs.Close();


            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }

                Console.WriteLine("The end of stream");
                sr.Close();
            }
        }
    }
}

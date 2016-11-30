using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWrite
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";

        static void Main(string[] args)
        {
            if (File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} already exists!", FILE_NAME);
                return;
            }

            FileStream fs = new FileStream(FILE_NAME, FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);

            for (int i = 0; i <= 11; i++)
            {
                w.Write("a");
            }
            w.Close();
            fs.Close();


            using (StreamWriter sw = File.AppendText("Test.txt"))
            {
                Log("hello", sw);
                Log("hello asp.net", sw);
                
                w.Close();
            }
        }

        public static void Log(string logMessage,TextWriter w)
        {
            w.Write("\r\nLog Entry:");
            w.Write("{0}", logMessage);

            w.Flush();
        }
    }
}

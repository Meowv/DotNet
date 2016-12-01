using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Message("In Main Function");
            Function1();
        }

        //[Obsolete("Dont't use Old Method!",true)]
        static void Function1()
        {
            MyClass.Message("In Function1");
            Function2();
        }

        static void Function2()
        {
            MyClass.Message("In Function2");
        }
    }

    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Casting_Delegate
{
    delegate void D(int x);

    class Program
    {
        static void Main(string[] args)
        {
            D cd1 = new D(C.M1);
            cd1(-1);
            Console.WriteLine();

            D cd2 = new D(C.M2);
            cd2(-2);
            Console.WriteLine();

            D cd3 = cd1 + cd2;
            cd3(10);
            Console.WriteLine();

            C c = new C();
            D cd4 = new D(c.M3);
            cd3 += cd4;
            cd3(30);
            Console.WriteLine();

            cd3 += cd1;
            cd3(20);
            Console.WriteLine();

            cd3 -= cd1;
            cd3(40);
            Console.WriteLine();

            cd3 -= cd2;
            cd3 -= cd4;
            cd3(50);
            Console.WriteLine();

            cd3 -= cd1;
            // cd3(60);//System.NullReferenceException:
            cd3 -= cd1;
        }
    }

    class C
    {
        public static void M1(int i)
        {
            Console.WriteLine("C.M1:" + i);
        }

        public static void M2(int i)
        {
            Console.WriteLine("C.M2:" + i);
        }

        public void M3(int i)
        {
            Console.WriteLine("C.M3:" + i);
        }
    }
}

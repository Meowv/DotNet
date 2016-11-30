using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            for (int c = 0; c < 5; c++)
            {
                intArray.SetItem(c, c * 5);
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.GetItem(c) + " ");
            }
            Console.WriteLine();

            intArray.GenericMethod<string>("Hello Generic!");
            intArray.GenericMethod<int>(100);

            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            for (int c = 0; c < 5; c++)
            {
                charArray.SetItem(c, (char)(c + 97));
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.GetItem(c) + " ");
            }
            Console.WriteLine();

            int m, n;
            char x, y;

            m = 10;
            n = 20;
            x ='I';
            y = 'V';
            Console.WriteLine("m:{0};n:{1}", m, n);
            Console.WriteLine("x:{0};y:{1}", x, y);

            Swap<int>(ref m, ref n);
            Swap<char>(ref x, ref y);

            Console.WriteLine("m:{0};n:{1}", m, n);
            Console.WriteLine("x:{0};y:{1}", x, y);

        }

        private static void Swap<T>(ref T lhs,ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    //Dictionary
    //class,interface,instance class

    public class MyGenericArray<T> where T:struct
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }

        public void GenericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }
    }

    //public class SubClass:MyGenericArray<int>
    //{

    //}

    //public class SubGenericClass<T> : MyGenericArray<T> where T : struct
    //{

    //}
}

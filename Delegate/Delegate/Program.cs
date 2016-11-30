using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int NumberChanger(int n);

    class Program
    {
        static int num = 10;

        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            nc1(20);
            Console.WriteLine("Value of Num:{0}", num);

            MyClass mc = new MyClass();
            NumberChanger nc2 = new NumberChanger(mc.AddNum);
            nc2(30);
            Console.WriteLine("Value of instance Num:{0}", mc.num);

            NumberChanger nc3 = new NumberChanger(mc.MutliNum);
            nc3(2);
            Console.WriteLine("Value of instance Num:{0}", mc.num);
        }

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
    }

    class MyClass
    {
        public int num = 10;

        public int AddNum(int p)
        {
            num += p;
            return num;
        }

        public int MutliNum(int p)
        {
            num *= p;
            return num;
        }
    }
}

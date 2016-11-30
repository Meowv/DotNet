using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    delegate T NumberChanger<T>(T n);

    class Program
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int p)
        {
            num *= p;
            return num;
        }

        static void Main(string[] args)
        {
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            nc1(25);
            Console.WriteLine(num);
            nc2(5);
            Console.WriteLine(num);
        }
    }
}

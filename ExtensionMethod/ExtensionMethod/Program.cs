using System;
using System.Linq;

namespace ExtensionMethod
{
    public enum Grades { F = 0, D = 1, C = 2, B = 3, A = 4 };

    class Program
    {
        static void Main(string[] args)
        {
            DemoLinq();

            StringCount();

            var g1 = Grades.D;
            var g2 = Grades.F;
            var g3 = Grades.A;
            Console.WriteLine("First {0} a passing grade", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Third {0} a passing grade", g3.Passing() ? "is" : "is not");

            Extesions.minPassing = Grades.C;
            Console.WriteLine("First {0} a passing grade", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Third {0} a passing grade", g3.Passing() ? "is" : "is not");
        }

        private static void DemoLinq()
        {
            int[] ints = { 10, 20, 30, 40, 50, 60, 70 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                Console.WriteLine("{0} ", i);
            }
        }

        private static void StringCount()
        {
            string s = "This is Meowv C# tutorial!";
            int i = s.WordCount();
            Console.WriteLine("Woed count of s is {0}", i);
        }

    }

    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class Extesions
    {
        public static Grades minPassing = Grades.D;

        public static bool Passing(this Grades grade)
        {
            return grade >= minPassing;
        }
    }
}
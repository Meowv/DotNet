using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectInitializer();

            InitializerAnonymousTyoe();

            CollectionInitilaizer();
        }

        private static void InitializerAnonymousTyoe()
        {
            var pet = new { Age = 22, Name = "QiXing" };

            var students = new List<StudentName> 
            { 
                new StudentName("QI", "Xing"), 
                new StudentName("Wu", "Shuang") 
            };

            var studentsFrom = new List<StudentFrom>
            {
                new StudentFrom{FirstName="Qi",City="Wuhan"}, 
                new StudentFrom{FirstName="Wu",City="Suizhou"},
            };

            var joinquery = from s in students
                            join f in studentsFrom on s.FirstName equals f.FirstName
                            select new { FirstName = s.FirstName, LastName = s.LastName, City = f.City };

            foreach (var j in joinquery)
            {
                Console.WriteLine("{0} {1} {2}", j.FirstName, j.LastName, j.City);
            }
        }

        private static void ObjectInitializer()
        {
            var student1 = new StudentName("QI", "Xing");
            var student2 = new StudentName { FirstName = "QI", LastName = "Xing" };
            var student3 = new StudentName { ID = 100 };
            var student4 = new StudentName("Wu", "Shuang") { ID = 101 };

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(student4.ToString());
        }

        private static void CollectionInitilaizer()
        {
            var students = new List<StudentName>
            {
                new StudentName{FirstName="QI",LastName="Xing",ID=100},
                new StudentName(){FirstName="Wu",LastName="Shuang",ID=101},
                new StudentName("XING","XING"){ID=102},
                null
            };

            foreach (var s in students)
            {
                if (s != null)
                {
                    Console.WriteLine(s.ToString());
                }
            }

            Dictionary<int, StudentName> studentDic = new Dictionary<int, StudentName>
            {
                {111,new StudentName{FirstName="QI",LastName="Xing",ID=100}},
                {112,new StudentName(){FirstName="Wu",LastName="Shuang",ID=101}}
            };

            foreach (var s in studentDic)
            {
                Console.WriteLine(s.Value.ToString());
            }
        }
    }

    public class StudentName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public StudentName() { }

        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + ID;
        }
    }

    public class StudentFrom
    {
        public string FirstName { get; set; }
        public string City { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicConcept();

            QuerySyntax();

            QueryOperations();
        }

        private static void BasicConcept()
        {
            // Linq:Lanuage Intergarted Query
            // select id,name from tableName;
            // IEnumerable
            // LINQ to SQL,LINQ to XML,LINQ to DataSet,LINQ to Objects

            int[] numbers = { 5, 10, 8, 3, 6, 9, 1, 2, 7, 4 };
            //1.Query syntax
            var numQuery1 = from num in numbers
                            where num % 2 == 0
                            orderby num
                            select num;
            //2.Method syntax
            var numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            foreach (var i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in numQuery2)
            {
                Console.Write(i + " ");
            }
        }

        private static void QuerySyntax()
        {
            //1.Data Source
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };

            //2.Query creation
            var numQuery = from num in numbers
                           where num % 2 == 0
                           select num;

            int numCount = numQuery.Count();
            numQuery.ToList();
            numQuery.ToArray();

            //3.Query execution
            foreach (var num in numQuery)
            {
                Console.WriteLine("{0,1}", num);
            }
        }

        private static void QueryOperations()
        {
            int[] numbes = { 0, 1, 2, 3, 4, 5, 6, 7 };
            var query = from num in numbes
                        where num % 2 == 1 || num % 3 == 1
                        orderby num ascending
                        select num;

            foreach (var num in query)
            {
                Console.Write("{0}", num);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Name = "qixing", City = "wuhan" });
            customers.Add(new Customer() { Name = "wushaung", City = "suizou" });
            customers.Add(new Customer() { Name = "xingxing", City = "wuhan" });

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "qixing", ID = 101 });
            employees.Add(new Employee() { Name = "shuangshuang", ID = 102 });

            var queryCustomers = from c in customers
                                 group c by c.City into cusGroup
                                 where cusGroup.Count() >= 2
                                 select new { City = cusGroup.Key, Number = cusGroup.Count() };

            foreach (var c in queryCustomers)
            {
                Console.WriteLine("{0} Count {1}", c.City, c.Number);
            }

            //foreach (var cg in queryCustomers)
            //{
            //    Console.WriteLine(cg.Key);
            //    foreach (var c in cg)
            //    {
            //        Console.WriteLine(" {0}", c.Name);
            //    }
            //}

            var queryJoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonID = e.ID, PersonCity = c.City };

            foreach (var p in queryJoin)
            {
                Console.WriteLine("{0} {1} {2}", p.PersonName, p.PersonID, p.PersonCity);
            }

            string[] strings = { "hello asp.net.", "This is Sunday!", "Are you OK?" };
            var stringQuery = from s in strings
                              let words = s.Split(' ')
                              from word in words
                              let w = word.ToUpper()
                              select w;

            foreach (var s in stringQuery)
            {
                Console.WriteLine("{0} ", s);
            }
        }
    }

    class Customer
    {
        public string Name
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}

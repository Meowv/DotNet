using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            RegexisMatch();

            RegexMatch();

            RegexReplace();

            RegexSplit();

            Matches();

            Groups();
        }

        private static void RegexisMatch()
        {
            string[] values = { "111-22-3333", "111-2-3333" };
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            foreach (var value in values)
            {
                if (Regex.IsMatch(value, pattern))
                {
                    Console.WriteLine("{0} is valid", value); ;
                }
                else
                {
                    Console.WriteLine("{0} is not valid", value);
                }
            }
        }

        private static void RegexMatch()
        {
            var input = "This is dotnet dotnet";
            var pattern = @"\b(\w+)\W(\1)\b";
            Match match = Regex.Match(input, pattern);

            while (match.Success)
            {
                Console.WriteLine("Duplication {0} found", match.Groups[1].Value);
                match = match.NextMatch();
            }
        }

        private static void RegexReplace()
        {
            string pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";
            string input = "Total cost:103.64";
            Console.WriteLine(Regex.Replace(input, pattern, replacement));
        }

        private static void RegexSplit()
        {
            string input = "1.Egg 2.Bread 3.Mike 4.Coffee";
            string pattern = @"\b\d{1,2}\.\s";
            foreach (string item in Regex.Split(input, pattern))
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void Matches()
        {
            MatchCollection matches;
            List<string> results = new List<string>();
            List<int> matchPosistion = new List<int>();

            Regex r = new Regex("abc");
            matches = r.Matches("123abc4abcd");
            foreach (Match match in matches)
            {
                Console.WriteLine("{0} found at position {1}", match.Value, match.Index);

                Console.WriteLine("{0}", match.Result("$&,hello dotnet!"));
            }
        }

        private static void Groups()
        {
            string input = "Qixing: March 7, 1995";
            string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                for (int ctr = 0; ctr < match.Groups.Count; ctr++)
                {
                    Console.WriteLine("Group {0}: {1}", ctr, match.Groups[ctr].Value);
                }
            }
        }
    }
}

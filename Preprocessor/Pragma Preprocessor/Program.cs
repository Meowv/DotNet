#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma_Preprocessor
{
#pragma warning disable 414,3021
    [CLSCompliant(false)]
    class Program
    {
        int i = 1;
        static void Main(string[] args)
        {
//#if DEBUG
//#line 100 "Special"
//#warning DEBUG is defined
//#error DEBUG is defined
//#endif

//#line default
//#warning !!!
//#error !!!

//#pragma checksum "filename" "{guid}" "check bytes"
        }
    }

#pragma warning restore 3021
    [CLSCompliant(false)]
    public class D
    {
        int i = 1;
        public static void M()
        { }
    }
}

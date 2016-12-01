#define DEBUG
#undef DEBUG
#define TRACE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hello Meowv
            // ...
            #endregion

#if (DEBUG)
            Console.WriteLine("Debuggimh is enable.");
#elif(TRACE)
            Console.WriteLine("Tracing is enabled.");
#else
            Console.WriteLine("Debuggimh is not enable.");
#endif
        }
    }
}

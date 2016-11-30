using System;
using System.IO;

namespace ExceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            //catch (Exception e)//System.Exception
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Anyway,We arrive here!");
            }

            Console.WriteLine("After try catch!");

            //throw new NullReferenceException();

            //Common Exception
            var ae = new ArgumentException();
            var ane = new ArgumentNullException();
            var aore = new ArgumentOutOfRangeException();
            var dne = new DirectoryNotFoundException();
            var fne = new FileNotFoundException();
            var ioe = new InvalidOperationException();
            var nie = new NotImplementedException();


            if (true)
            {
                //logic
            }

            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                //logic
            }
        }
    }
}

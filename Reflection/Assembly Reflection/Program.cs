using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly objAssembly;
            objAssembly = Assembly.Load("mscorlib,Version=4.0.0.0, Culture=neutral,PublicKeyToken=b77a5c561934e089");

            Type[] types = objAssembly.GetTypes();

            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
            }

            objAssembly = Assembly.GetExecutingAssembly();
            Type tt = objAssembly.GetType("Reflection.Car",false,true);
            object obj = Activator.CreateInstance(tt);
            MethodInfo mi = tt.GetMethod("IsMoving");
            var isMoving = (bool)mi.Invoke(obj, null);
            if (isMoving)
            {
                Console.WriteLine("Is moving");
            }
            else
            {
                Console.WriteLine("Not is moving");
            }
        }
    }

    public class Car
    {
        public bool IsMoving()
        {
            return true;
        }
    }
}

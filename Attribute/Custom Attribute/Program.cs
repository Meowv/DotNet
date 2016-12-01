using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            HelpAttribute helpAttribute;

            foreach (var attr in typeof(AnyClass).GetCustomAttributes(true))
            {
                helpAttribute = attr as HelpAttribute;
                if (null != helpAttribute)
                {
                    Console.WriteLine("AnyClass Description:{0}", helpAttribute.Description);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class HelpAttribute : Attribute
    {
        protected string description;

        public HelpAttribute(string description_in)
        {
            this.description = description_in;
        }

        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public string Name
        {
            get;
            set;
        }
    }

    [Help("this is a do-nothing class", Name = "Meowv")]
    public class AnyClass
    {
    }
}

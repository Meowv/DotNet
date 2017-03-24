using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDesc { get; set; }

        public Users UserOwner { get; set; }

        public string CreateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApplication1.Models
{
    public class Order
    {
        public int id { set; get; }
        public DateTime orderDate {set; get;}
        public int customerID { set; get; }
    }
}

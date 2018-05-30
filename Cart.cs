using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Cart
    {
        public int cart_id { get; set; }
        public int order_id { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string market { get; set; }
        public string note { get; set; }
        public string route { get; set; }
    }
}

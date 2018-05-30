using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class cartDetail
    {
        public int cart_id { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double total {
            get
            {
                return quantity * price;
            }
        }
        public string note { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportViewerOrders
{
    class Orders
    {
        public int Order_ID { get; set; }

        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public string  Name { get; set; }
        public string  Products { get; set; } 
    }
}

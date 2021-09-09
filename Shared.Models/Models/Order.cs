using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Models
{
    public class Order
    {
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }

        public string OrderDescription { get; set; }
        public int TotalAmount { get; set; }
    }
}

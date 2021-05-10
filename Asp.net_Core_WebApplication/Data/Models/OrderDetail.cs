using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_WebApplication.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int OrderID { get; set; }
        public int CarID { get; set; }
        public uint price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Bill
    {
        public int? Billid { get; set; }
        public int? Orderid { get; set; }
        public long? TotBill { get; set; }
        public string Ostatus { get; set; }
    }
}

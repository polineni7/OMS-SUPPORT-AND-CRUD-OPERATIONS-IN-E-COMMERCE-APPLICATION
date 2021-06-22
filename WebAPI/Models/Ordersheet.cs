using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Ordersheet
    {
        public int? Oid { get; set; }
        public int Sno { get; set; }
        public int? Pid { get; set; }
        public string Venname { get; set; }
        public string Clientname { get; set; }
        public string Pname { get; set; }
        public decimal? Rate { get; set; }
        public int? Qty { get; set; }
        public string Pdescription { get; set; }

    }
}

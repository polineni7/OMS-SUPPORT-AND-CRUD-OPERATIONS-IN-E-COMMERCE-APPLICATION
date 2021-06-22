using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Productreview
    {
        public int? Oid { get; set; }
        public int Sno { get; set; }
        public int? Pid { get; set; }
        public string Pname { get; set; }
        public decimal? Rate { get; set; }
        public int? Pqty { get; set; }
        public string Pdescription { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Vendor
    {
        public int Vid { get; set; }
        public string Vname { get; set; }
        public string Vaddress { get; set; }
        public string Vbranch { get; set; }
        public long? Vphone { get; set; }
        public string Vemail { get; set; }
        public string Vdescription { get; set; }
        public string Vothernotes { get; set; }
    }
}

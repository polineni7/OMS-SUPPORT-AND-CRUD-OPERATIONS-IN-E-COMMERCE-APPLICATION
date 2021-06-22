using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Shipingdetail
    {
        public int Billid { get; set; }
        public int? Srid { get; set; }
        public int? Oid { get; set; }
        public int? Pid { get; set; }
        public string Transporttype { get; set; }
        public string PartialNo { get; set; }
        public int? Proceditems { get; set; }
        public string Pname { get; set; }
        public decimal? Rate { get; set; }
        public int? Noqty { get; set; }
        public string Venname { get; set; }
        public string Clientname { get; set; }
        public string Pdescription { get; set; }
        public DateTime? Shipingdate { get; set; }

    }
}

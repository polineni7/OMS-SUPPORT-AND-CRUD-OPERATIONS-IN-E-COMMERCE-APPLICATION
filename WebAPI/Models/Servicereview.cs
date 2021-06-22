using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Servicereview
    {

        public int Srid { get; set; }
        public int? Oid { get; set; }
        public int? So { get; set; }
        public int? Pid { get; set; }
        public string Transporttype { get; set; }
        public string PartialNo { get; set; }
        public int? Proceditems { get; set; }
        public string Pname { get; set; }
        public decimal? Rate { get; set; }
        public int? Pqty { get; set; }
        public string Pdescription { get; set; }

    }
}

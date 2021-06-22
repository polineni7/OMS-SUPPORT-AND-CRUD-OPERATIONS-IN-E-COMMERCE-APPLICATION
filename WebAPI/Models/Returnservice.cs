using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Returnservice
    {
        public int Rid { get; set; }
        public int? Oid { get; set; }
        public int? Pid { get; set; }
        public string Transporttype { get; set; }
        public string PartialNo { get; set; }
        public string Pname { get; set; }
        public decimal? Rate { get; set; }
        public int? Pqty { get; set; }
        public string Pdescription { get; set; }
        public DateTime? Returndate { get; set; }

    }
}

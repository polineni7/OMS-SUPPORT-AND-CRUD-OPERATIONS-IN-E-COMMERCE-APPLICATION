using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Createorder
    {

        public int Oid { get; set; }
        public int? Ponumber { get; set; }
        public string Clienname { get; set; }
        public string Username { get; set; }
        public string Obranch { get; set; }
        public long? Ophone { get; set; }
        public string Oaddress { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Deadlinedate { get; set; }
    }
}

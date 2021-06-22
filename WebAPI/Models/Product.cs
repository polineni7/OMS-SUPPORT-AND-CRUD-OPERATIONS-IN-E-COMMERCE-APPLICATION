using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Pname { get; set; }
        public int? Rate { get; set; }
        public string Pdescription { get; set; }
        public DateTime? Rdate { get; set; }
    }
}

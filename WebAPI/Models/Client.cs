using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Caddress { get; set; }
        public string Branch { get; set; }
        public long? Phone { get; set; }
        public string Email { get; set; }
        public string Cdescription { get; set; }
        public string Cothernotes { get; set; }
    }
}

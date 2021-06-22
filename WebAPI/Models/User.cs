using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Mailid { get; set; }
        public string Userpassword { get; set; }
    }
}

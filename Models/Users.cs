using System;
using System.Collections.Generic;

namespace netcoreproject.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
        public byte[] Created { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Address
    {
        public int id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
    }
}

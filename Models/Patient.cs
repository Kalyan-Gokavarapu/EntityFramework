using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string MRN { get; set; }
        public string Name { get; set; }

        public List<Exam> Exams { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Email> Emails { get; set; }
    }
}

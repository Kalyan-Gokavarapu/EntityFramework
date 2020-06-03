using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Exam
    {
        public int id { get; set; }
        public string Modality { get; set; }
        public string ExamCode { get; set; }
    }
}

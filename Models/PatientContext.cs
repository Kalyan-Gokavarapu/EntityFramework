using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions options) : base(options) { }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Email> Email { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////.UpdateRange(new Patient());
            //modelBuilder.Entity<Patient>().HasData(
            //    new Patient
            //    {
            //        id =1,
            //        MRN = "12345",
            //        Name = "Patient 1"
            //    },
            //    new Patient { 
                
            //    },
            //    new Patient { 
                
            //    }
            //    );
            
        }
    }
}

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
            //        id = 1,
            //        MRN = "11111",
            //        Name = "Patient 1",
            //        Exams = new List<Exam>()
            //        {
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            },
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            },
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            }
            //        },
            //        Addresses = new List<Address>()
            //        {
            //            new Address{
            //            Country="India",
            //            State="Karnataka",
            //            Pin="100200"
            //            }
            //        },
            //        Emails = new List<Email>()
            //        {
            //            new Email{
            //            EmailAddress="mail@web.com"
            //            },
            //            new Email{
            //            EmailAddress="mali@ai.com"
            //            }
            //        }
            //    },
            //    new Patient
            //    {
            //        id = 2,
            //        MRN = "22222",
            //        Name = "Patient 2",
            //        Exams = new List<Exam>()
            //        {
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            },
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            },
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            }
            //        },
            //        Addresses = new List<Address>()
            //        {
            //            new Address{
            //            Country="India",
            //            State="Karnataka",
            //            Pin="100200"
            //            }
            //        },
            //        Emails = new List<Email>()
            //        {
            //            new Email{
            //            EmailAddress="mail@web.com"
            //            },
            //            new Email{
            //            EmailAddress="mali@ai.com"
            //            }
            //        }
            //    },
            //    new Patient
            //    {
            //        id = 3,
            //        MRN = "33333",
            //        Name = "Patient 3",
            //        Exams = new List<Exam>()
            //        {
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            },
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            },
            //            new Exam{
            //            ExamCode ="cd1",
            //            Modality ="mod1"
            //            }
            //        },
            //        Addresses = new List<Address>()
            //        {
            //            new Address{
            //            Country="India",
            //            State="Karnataka",
            //            Pin="100200"
            //            }
            //        },
            //        Emails = new List<Email>()
            //        {
            //            new Email{
            //            EmailAddress="mail@web.com"
            //            },
            //            new Email{
            //            EmailAddress="mali@ai.com"
            //            }
            //        }
            //    });
        }
    }
}

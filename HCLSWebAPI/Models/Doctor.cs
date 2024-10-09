using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;

namespace HCLSWebAPI.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        public int DocId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public bool Logged { get; set; }
        public bool Assigned { get; set; }
        [ForeignKey("DoctorSpecialization")]
        public int DocSpecId { get; set; }

        [ForeignKey("Department")]
        public int DeptNo { get; set; }

        public ICollection<Patient>Patient {  get; set; }

        public DoctorSpecialization DoctorSpecialization { get; set; }
        public Department Department { get; set; }
         
    }
}

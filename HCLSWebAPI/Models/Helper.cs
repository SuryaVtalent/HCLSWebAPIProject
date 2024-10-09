using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Helper")]
    public class Helper
    {
        [Key]
        public int HelpId { get; set; }
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

        [ForeignKey("Department")]
        public int DeptNo { get; set; }

        public ICollection<Patient>Patient {  get; set; }
        public Department Department { get; set; }
    }
}

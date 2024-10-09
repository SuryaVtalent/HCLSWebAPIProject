using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Receptionist")]
    public class Receptionist
    {
        [Key]
        public int RecpId { get; set; }
        public string Name { get; set; }
        public DateTime DOB {  get; set; }
        public DateTime DOJ { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public bool Active {  get; set; }
        public bool Logged {  get; set; }

        [ForeignKey("Department")]
        public int DeptNo { get; set; }

        public ICollection<Patient>Patient {  get; set; }

        public Department Department { get; set; }
    }
}

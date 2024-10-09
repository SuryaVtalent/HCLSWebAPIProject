using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        public string DName { get; set; }

        public ICollection<Receptionist>Receptionist { get; set; }
        public ICollection<Helper>Helper { get; set; }
        public ICollection<Lab>Lab { get; set; }
        public ICollection<Doctor>Doctor { get; set; }
    }
}

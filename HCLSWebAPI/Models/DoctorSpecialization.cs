using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("DoctorSpecialization")]
    public class DoctorSpecialization
    {
        [Key]
        public int DocSpecId { get; set; }
        public string Specialization {  get; set; }
        public ICollection<Doctor>Doctor {  get; set; }
        public ICollection<Patient>Patient { get; set; }

    }
}

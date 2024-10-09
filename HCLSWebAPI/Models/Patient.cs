using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace HCLSWebAPI.Models
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string CameForDiagnosist { get; set; }
        public DateTime VisitedDate { get; set; }
        public DateTime UpComingVisitDate { get; set; }
        public decimal BillAmount { get; set; }
        public string MedicalDescription { get; set; }
        public bool Active {  get; set; }

        [ForeignKey("DoctorSpecialization")]
        public int DocSpecId { get; set; }
        [ForeignKey("Receptionist")]
        public int RecpId { get; set; }
        [ForeignKey("Helper")]
        public int HelpId { get; set; }
        [ForeignKey("Doctor")]
        public int DocId { get; set; }
        [ForeignKey("Lab")]
        public int LabId { get; set; }

        [ForeignKey("PatientStatus")]
        public int StatId { get; set; }

        public DoctorSpecialization DoctorSpecialization { get; set; }
        public Receptionist Receptionist { get; set; }
        public Helper Helper {  get; set; }
        public Doctor Doctor {  get; set; }
        public Lab Lab { get; set; }
        public PatientStatus PatientStatus { get; set; }
    }
}

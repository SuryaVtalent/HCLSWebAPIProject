using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSWebAPI.DataContext
{
    public class DBContextt:DbContext
    {
        public DBContextt(DbContextOptions<DBContextt>options):base(options) { }

        public DbSet<AdminTypes>AdminType { get; set; }
        public DbSet<Admins>Admin {  get; set; }
        public DbSet<Department>Departments { get; set; }
        public DbSet<Receptionist>Receptionists { get; set; }
        public DbSet<Helper>Helpers { get; set; }
        public DbSet<Lab>Labs { get; set; }
        public DbSet<DoctorSpecialization>DoctorSpecialize { get; set; }
        public DbSet<Doctor>Doctors { get; set; }
        public DbSet<PatientStatus>PatientStatuss { get; set; }
        public DbSet<Patient>Patients { get; set; }
    }   
}

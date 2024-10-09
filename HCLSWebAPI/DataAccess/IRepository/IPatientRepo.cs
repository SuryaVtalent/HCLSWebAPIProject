using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IPatientRepo
    {
        public Task<List<Patient>> GetAllPatientDetails();
        public Task<Patient> GetPatientById(int PatientId);
        public Task<Patient> GetPatientByEmailandPassword(string Email, string Password);
        public Task<Patient> GetPatientbyDocSpecId(int DocSpecId);
        public Task<Patient> GetPatientByRecpId(int RecpId);
        public Task<Patient> GetPatientByHelpId(int HelpId);
        public Task<Patient> GetPatientByDocId(int DocId);
        public Task<Patient> GetPatientByLabId(int LabId);
        public Task<Patient> GetPatientByStatId(int StatId);
        public Task<int> InsertPatient(Patient patient);
        public Task<int> UpdatePatient(Patient patient);
        public Task<int> DeletePatient(int PatientId);
    }
}

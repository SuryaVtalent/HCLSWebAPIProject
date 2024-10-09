using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IPatientStatusRepo
    {
        public Task<List<PatientStatus>> GetAllPatientStatus();
        public Task<PatientStatus> GetPatientStatusId(int StatId);
        public Task<int> Insertpatientstatus(PatientStatus patientStatus);
        public Task<int> Updatepatientstatus(PatientStatus patientStatus);
        public Task<int> Deletepatientstatus(int StatId);
    }
}

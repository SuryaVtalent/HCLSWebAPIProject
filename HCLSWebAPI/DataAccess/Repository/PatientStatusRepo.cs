using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class PatientStatusRepo:IPatientStatusRepo
    {
        public DBContextt Patrep;

        public PatientStatusRepo(DBContextt patrep)
        {
            Patrep = patrep;
        }

        public async Task<int> Deletepatientstatus(int StatId)
        {
            var pat=Patrep.PatientStatuss.Find(StatId);
            Patrep.PatientStatuss.Remove(pat);
            return await Patrep.SaveChangesAsync();
        }

        public async Task<List<PatientStatus>> GetAllPatientStatus()
        {
          return await Patrep.PatientStatuss.ToListAsync();
        }

        public async Task<PatientStatus> GetPatientStatusId(int StatId)
        {
            return await Patrep.PatientStatuss.FindAsync();
        }

        public async Task<int> Insertpatientstatus(PatientStatus patientStatus)
        {
           await Patrep.PatientStatuss.AddAsync(patientStatus);
            return await Patrep.SaveChangesAsync();
        }

        public async Task<int> Updatepatientstatus(PatientStatus patientStatus)
        {
            Patrep.PatientStatuss.Update(patientStatus);
            return await Patrep.SaveChangesAsync();
        }
    }
}

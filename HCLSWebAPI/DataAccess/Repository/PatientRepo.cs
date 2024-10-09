using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class PatientRepo:IPatientRepo
    {
        public DBContextt PatiRep;

        public PatientRepo(DBContextt patrep)
        {
            PatiRep = patrep;
        }

        
        public async Task<List<Patient>> GetAllPatientDetails()
        {
          return await PatiRep.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatientByDocId(int DocId)
        {
         return await  PatiRep.Patients.Where(x => x.DocId == DocId).SingleOrDefaultAsync();
        }

        public async Task<Patient> GetPatientbyDocSpecId(int DocSpecId)
        {
         return await  PatiRep.Patients.Where(x => x.DocSpecId == DocSpecId).SingleOrDefaultAsync();   
        }

        public async Task<Patient> GetPatientByEmailandPassword(string Email, string Password)
        {
          return await PatiRep.Patients.Where(x=>x.Email==Email && x.Password==Password).SingleOrDefaultAsync();
        }

        public async Task<Patient> GetPatientByHelpId(int HelpId)
        {
         return await PatiRep.Patients.Where(x=>x.HelpId==HelpId).SingleOrDefaultAsync();
        }

        public async Task<Patient> GetPatientById(int PatientId)
        {
          return await PatiRep.Patients.FindAsync(PatientId);
        }

        public async Task<Patient> GetPatientByLabId(int LabId)
        {
        return  await  PatiRep.Patients.Where(x => x.LabId == LabId).SingleOrDefaultAsync();
        }

        public async Task<Patient> GetPatientByRecpId(int RecpId)
        {
           return await PatiRep.Patients.Where(x => x.RecpId == RecpId).SingleOrDefaultAsync();
        }

        public async Task<Patient> GetPatientByStatId(int StatId)
        {
          return await PatiRep.Patients.Where(x=>x.StatId==StatId).SingleOrDefaultAsync();
        }

        public async Task<int> InsertPatient(Patient patient)
        {
           await PatiRep.Patients.AddAsync(patient);
            return await PatiRep.SaveChangesAsync();
        }

        public async Task<int> UpdatePatient(Patient patient)
        {
            PatiRep.Patients.Update(patient);
            return await PatiRep.SaveChangesAsync();
        }


        public async Task<int> DeletePatient(int PatientId)
        {
            var Pat = PatiRep.Patients.Find(PatientId);
            PatiRep.Patients.Remove(Pat);
            return await PatiRep.SaveChangesAsync();
        }
    }
}

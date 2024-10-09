using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class DocRepo:IDocRepo
    {
        public DBContextt DocRep;
        public DocRepo(DBContextt docRep)
        {
            DocRep = docRep;
        }

        public async Task<List<Doctor>> AllDoctors()
        {
         return await  DocRep.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetDocByEmailandPassword(string Email, string Password)
        {
            return await DocRep.Doctors.Where(x=>x.Email==Email &&x.Password==Password).SingleOrDefaultAsync();
        }

        public async Task<List<Doctor>> GetDoctorByDeptNo(int DeptNo)
        {
            return await DocRep.Doctors.Where(x=>x.DeptNo==DeptNo).ToListAsync();
        }

        public async Task<List<Doctor>> GetDoctorByDocSpecId(int DocSpecId)
        {
            return await DocRep.Doctors.Where(x=>x.DocSpecId==DocSpecId).ToListAsync();
        }

        public async Task<Doctor> GetDoctorById(int DocId)
        {
            return await DocRep.Doctors.FindAsync(DocId);
        }

        public async Task<int> InsertDoctor(Doctor doctor)
        {
           await DocRep.Doctors.AddAsync(doctor);
            return await DocRep.SaveChangesAsync();
        }

        public async Task<int> UpdateDoctor(Doctor doctor)
        {
            DocRep.Doctors.Update(doctor);
            return await DocRep.SaveChangesAsync();
        }

        public async Task<int> DeleteDoctor(int DocId)
        {
            var doc=DocRep.Doctors.Find(DocId);
            DocRep.Doctors.Remove(doc);
            return await DocRep.SaveChangesAsync();
        }
    }
}

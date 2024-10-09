using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class LabRepo : ILabRepo
    {
        public DBContextt LabRep;

        public LabRepo(DBContextt labRep)
        {
            LabRep = labRep;
        }

        public async Task<Lab> CLogin(string Email, string Password)
        {
          return await LabRep.Labs.Where(x => x.Email == Email && x.Password == Password).SingleOrDefaultAsync();
        }

        public async Task<int> DeleteLab(int LabId)
        {
           var lab= LabRep.Labs.Find(LabId);
            LabRep.Labs.Remove(lab);
            return await LabRep.SaveChangesAsync();
        }

        public async Task<List<Lab>> GetAllLabDetails()
        {
          return await LabRep.Labs.ToListAsync();
        }

        public async Task<List<Lab>> GetLabByDeptNo(int DeptNo)
        {
            return await LabRep.Labs.Where(x=>x.DeptNo==DeptNo).ToListAsync();
        }

        public async Task<Lab> GetLabId(int LabId)
        {
          return await LabRep.Labs.FindAsync(LabId);
        }

        public async Task<int> InsertLab(Lab lab)
        {
           await LabRep.Labs.AddAsync(lab);
            return await LabRep.SaveChangesAsync();
        }

        public async Task<int> UpdateLab(Lab lab)
        {
            LabRep.Labs.Update(lab);
            return await LabRep.SaveChangesAsync();
        }
    }
}

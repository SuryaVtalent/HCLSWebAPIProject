using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class ReceptionRepo:IReceptionRepo
    {
        public DBContextt RecRep;

        public ReceptionRepo(DBContextt recRep)
        {
            RecRep = recRep;
        }

        public async Task<List<Receptionist>> AllReceptionDetails()
        {
         return await  RecRep.Receptionists.ToListAsync();
        }

        


        public async Task<Receptionist> GetReceptionByEmailandPassword(string Email, string Password)
        {
          return await RecRep.Receptionists.Where(x => x.Email == Email && x.Password == Password).SingleOrDefaultAsync();
        }

        public async Task<Receptionist> GetReceptionById(int RecpId)
        {
          return await RecRep.Receptionists.FindAsync(RecpId);
        }

        public async Task<int> InsertReception(Receptionist receptionist)
        {
           await RecRep.Receptionists.AddAsync(receptionist);
            return await RecRep.SaveChangesAsync();
        }

        public async Task<int> UpdateReception(Receptionist receptionist)
        {
            RecRep.Receptionists.Update(receptionist);
            return await RecRep.SaveChangesAsync();
        }

        public async Task<int> DeleteReception(int RecpId)
        {
            var rec = RecRep.Receptionists.Find(RecpId);
            RecRep.Receptionists.Remove(rec);
            return await RecRep.SaveChangesAsync();
        }

        public async Task<List<Receptionist>> GetReceptionByDeptId(int DeptNo)
        {
            return await RecRep.Receptionists.Where(x => x.DeptNo == DeptNo).ToListAsync();

        }
    }
}

using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class HelperRepo:IHelperRepo
    {
        public DBContextt HelRep;

        public HelperRepo(DBContextt helRep)
        {
            HelRep = helRep;
        }

        public async Task<Helper> CheckLogin(string Email, string Password)
        {
          return await HelRep.Helpers.Where(x => x.Email == Email && x.Password == Password).SingleOrDefaultAsync();
        }

        

        public async Task<List<Helper>> GetAllHelperDetails()
        {
         return await  HelRep.Helpers.ToListAsync();
        }

        

        public async Task<Helper> GetHelperById(int HelpId)
        {
          return await HelRep.Helpers.FindAsync(HelpId);
        }

        public async Task<int> InsertHelper(Helper helper)
        {
             await HelRep.Helpers.AddAsync(helper);
            return await HelRep.SaveChangesAsync();
        }

        public async Task<int> UpdateHelper(Helper helper)
        {
            HelRep.Helpers.Update(helper);
            return await HelRep.SaveChangesAsync();
        }

        public async Task<int> DeleteHelper(int HelpId)
        {
            var help = HelRep.Helpers.Find(HelpId);
            HelRep.Helpers.Remove(help);
            return await HelRep.SaveChangesAsync();
        }

        public async Task<List<Helper>> GetHelperByDeptNo(int DeptNo)
        {
            return await HelRep.Helpers.Where(x => x.DeptNo == DeptNo).ToListAsync();

        }
    }
}

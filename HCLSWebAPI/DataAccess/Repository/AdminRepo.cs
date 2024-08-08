using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class AdminRepo:IAdminRepo
    {
        public DBContextt AdmRep;

        public AdminRepo(DBContextt _AdmRep)
        {
            AdmRep=_AdmRep;
        }

        public async Task<Admins> AdminByAdminEmail(string Email)
        {
           return await AdmRep.Admin.Where(x => x.Email == Email).SingleOrDefaultAsync();
        }

        public async Task<List<Admins>> AllOperationalAdmins()
        {
          return await  AdmRep.Admin.ToListAsync();
        }

        public async Task<int> AdminRegistration(Admins admin)
        {
           await AdmRep.Admin.AddAsync(admin);
            return await AdmRep.SaveChangesAsync();
        }

        public async Task<int> UpdateAdmin(Admins admin)
        {
            AdmRep.Admin.Update(admin);
            return await AdmRep.SaveChangesAsync();
        }
        public async Task<int> DeleteAdmin(int AdminId)
        {
            var admi = AdmRep.Admin.Find(AdminId);
            AdmRep.Admin.Remove(admi);
            return await AdmRep.SaveChangesAsync();
        }

        
    }
}

using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class AdminTypeRepo:IAdmintypeRepo
    {
        public DBContextt DbRep;

        public AdminTypeRepo(DBContextt _DbRep)
        {
            DbRep = _DbRep;
        }

        public async Task<List<AdminTypes>> AllAdminTypes()
        {
          return await DbRep.AdminType.ToListAsync();
        }

        public async Task<int> DeleteAdminType(int AdminTypeId)
        {
            var adm=DbRep.AdminType.Find(AdminTypeId);
            DbRep.AdminType.Remove(adm);
            return await DbRep.SaveChangesAsync();
        }

        public async Task<AdminTypes> GetAdminTypeById(int AdminTypeId)
        {
          return await  DbRep.AdminType.FindAsync(AdminTypeId);
        }

        public async Task<List<AdminTypes>> GetAdminTypeByName(string AdminTypeName)
        {
          return await  DbRep.AdminType.Where(x=>x.AdminTypeName==AdminTypeName).ToListAsync();
        }

        public async Task<int> InsertAdminType(AdminTypes Adminty)
        {
           await DbRep.AdminType.AddAsync(Adminty);
            return await DbRep.SaveChangesAsync();
        }

        public async Task<int> UpdateAdminType(AdminTypes Adminty)
        {
            DbRep.AdminType.Update(Adminty);
            return await DbRep.SaveChangesAsync();
        }
    }
}

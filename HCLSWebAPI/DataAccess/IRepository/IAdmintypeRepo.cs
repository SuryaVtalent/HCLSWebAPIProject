using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdmintypeRepo
    {

        public Task<List<AdminTypes>> AllAdminTypes();
        public Task<AdminTypes> GetAdminTypeById(int AdminTypeId);
        public Task<List<AdminTypes>> GetAdminTypeByName(string AdminTypeName);

        public Task<int> InsertAdminType(AdminTypes Adminty);
        public Task<int> UpdateAdminType(AdminTypes Adminty);
        public Task<int> DeleteAdminType(int AdminTypeId);
    }
}

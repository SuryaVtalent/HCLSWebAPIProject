using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IHelperRepo
    {
        public Task<List<Helper>> GetAllHelperDetails();
        public Task<Helper> GetHelperById(int HelpId);
        public Task<List<Helper>> GetHelperByDeptNo(int DeptNo);
        public Task<Helper> CheckLogin(string Email, string Password);
        public Task<int> InsertHelper(Helper helper);
        public Task<int> UpdateHelper(Helper helper);
        public Task<int> DeleteHelper(int HelpId);
    }
}

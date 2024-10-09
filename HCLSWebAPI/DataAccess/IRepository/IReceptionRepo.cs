using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IReceptionRepo
    {
        public Task<List<Receptionist>> AllReceptionDetails();
        public Task<Receptionist> GetReceptionById(int RecpId);
        public Task<List<Receptionist>> GetReceptionByDeptId(int DeptNo);
        public Task<Receptionist> GetReceptionByEmailandPassword(string Email,string Password);
        public Task<int> InsertReception(Receptionist receptionist);
        public Task<int> UpdateReception(Receptionist receptionist);
        public Task<int> DeleteReception(int RecpId);
    }
}

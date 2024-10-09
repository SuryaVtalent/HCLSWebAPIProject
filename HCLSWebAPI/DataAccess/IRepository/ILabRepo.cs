using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface ILabRepo
    {
        public Task<List<Lab>> GetAllLabDetails();
        public Task<Lab> GetLabId(int LabId);
        public Task<List<Lab>> GetLabByDeptNo(int DeptNo);
        public Task<Lab> CLogin(string Email,string Password);
        public Task<int> InsertLab(Lab lab);
        public Task<int> UpdateLab(Lab lab);
        public Task<int> DeleteLab(int LabId);
        
    }
}

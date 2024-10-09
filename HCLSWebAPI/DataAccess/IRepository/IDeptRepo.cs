using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IDeptRepo
    {
        public Task<List<Department>> AllDepartments();
        public Task<Department> GetDeptById(int DeptNo);
        public Task<int> InsertDept(Department dept);
        public Task<int> UpdateDept(Department dept);
        public Task<int> DeleteDept(int DeptNo);

    }
}

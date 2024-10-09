using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class DeptRepo:IDeptRepo
    {
        public DBContextt DptRep;

        public DeptRepo(DBContextt dptRep)
        {
            DptRep = dptRep;
        }

        public async Task<List<Department>> AllDepartments()
        {
          return await DptRep.Departments.ToListAsync();
        }

        public async Task<Department> GetDeptById(int DeptNo)
        {
          return await DptRep.Departments.FindAsync(DeptNo);
        }

        public async Task<int> InsertDept(Department dept)
        {
           await DptRep.Departments.AddAsync(dept);
            return await DptRep.SaveChangesAsync();
        }

        public async Task<int> UpdateDept(Department dept)
        {
            DptRep.Departments.Update(dept);
            return await DptRep.SaveChangesAsync();
        }

        public async Task<int> DeleteDept(int DeptNo)
        {
            var deptid = DptRep.Departments.Find(DeptNo);
            DptRep.Departments.Remove(deptid);
            return await DptRep.SaveChangesAsync();
        }
    }
}

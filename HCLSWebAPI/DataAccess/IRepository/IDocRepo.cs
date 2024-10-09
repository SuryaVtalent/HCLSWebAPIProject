using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IDocRepo
    {
        public Task<List<Doctor>> AllDoctors();
        public Task<Doctor> GetDoctorById(int DocId);
        public Task<List<Doctor>> GetDoctorByDeptNo(int DeptNo);
        public Task<List<Doctor>> GetDoctorByDocSpecId(int DocSpecId);
        public Task<Doctor> GetDocByEmailandPassword(string Email,string Password);
        public Task<int> InsertDoctor(Doctor doctor);
        public Task<int> UpdateDoctor(Doctor doctor);
        public Task<int> DeleteDoctor(int DocId);
    }
}

using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IDocSpecRepo
    {
        public Task<List<DoctorSpecialization>> AllDocSpecDetails();
        public Task<DoctorSpecialization> GetDocSpecById(int DocSpecId);
        public Task<int> InsertDocSpec(DoctorSpecialization docspec);
        public Task<int> UpdateDocSpec(DoctorSpecialization docspec);
        public Task<int> DeleteDocSpec(int DocSpecId);
    }
}

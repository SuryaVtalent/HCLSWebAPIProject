using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class DocSpecRepo:IDocSpecRepo
    {
        public DBContextt DocSpecRep;

        public DocSpecRepo(DBContextt docSpecRep)
        {
            DocSpecRep = docSpecRep;
        }

        public async Task<List<DoctorSpecialization>> AllDocSpecDetails()
        {
           return await DocSpecRep.DoctorSpecialize.ToListAsync();

        }

        public async Task<DoctorSpecialization> GetDocSpecById(int DocSpecId)
        {
          return await DocSpecRep.DoctorSpecialize.FindAsync(DocSpecId);
        }

        public async Task<int> InsertDocSpec(DoctorSpecialization docspec)
        {
           await DocSpecRep.DoctorSpecialize.AddAsync(docspec);
            return await DocSpecRep.SaveChangesAsync();
        }

        public async Task<int> UpdateDocSpec(DoctorSpecialization docspec)
        {
            DocSpecRep.DoctorSpecialize.Update(docspec);
            return await DocSpecRep.SaveChangesAsync();
        }

        public async Task<int> DeleteDocSpec(int DocSpecId)
        {
            var docspec = DocSpecRep.DoctorSpecialize.Find(DocSpecId);
            DocSpecRep.DoctorSpecialize.Remove(docspec);
            return await DocSpecRep.SaveChangesAsync();
        }
    }
}

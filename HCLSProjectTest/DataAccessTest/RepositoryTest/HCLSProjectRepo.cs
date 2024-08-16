using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCLSProjectTest.DataAccessTest.RepositoryTest
{
    public class HCLSProjectRepo : IAdminRepo
    {

        //Create Instance object 

        public List<Admins> _db=new List<Admins>();

        public Task<Admins> AdminByAdminEmail(string Email)
        {
            Admins adm = null;

            foreach (Admins a in _db)
            {
                if (a.Email == Email)
                {
                    adm = a;
                    break;
                }
            }
            return Task.FromResult(adm);
        }

        public Task<int> AdminRegistration(Admins admin)
        {
            _db.Add(admin);
            return Task.FromResult(SaveChanges());
        }

        public Task<List<Admins>> AllOperationalAdmins()
        {
            return Task.FromResult(_db);
        }

        public Task<int> DeleteAdmin(int AdminId)
        {
            Admins adm=null;

            foreach (Admins a in _db)
            {
                if (a.AdminId==AdminId)
                {
                    adm = a;
                    break;
                }
            }
            return Task.FromResult(adm.AdminId);
        }

        public Task<int> UpdateAdmin(Admins admin)
        {
            foreach (Admins a in _db)
            {
                if (a.AdminId==admin.AdminId)
                {
                    a.Name = admin.Name;a.Address = admin.Address;a.Active = admin.Active;a.Email = admin.Email;
                    a.Gender = admin.Gender;a.Password = admin.Password;a.AdminTypeId = admin.AdminTypeId;
                    break;
                }
            }
            return Task.FromResult(SaveChanges());
        }


        public int SaveChanges()
        {
            return 1;
        }
        public int TotalRecords()
        {
            return _db.Count;
        }

        public Task<List<Admins>> CheckLogin(string Email, string Password)
        {
            Admins adm = null;

            foreach (Admins a in _db)
            {
                if (a.Email==Email && a.Password==Password)
                {
                    adm = a;
                    break;
                }
            }
            return Task.FromResult(_db);
        }
    }
}

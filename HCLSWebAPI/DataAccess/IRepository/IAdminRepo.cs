﻿using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdminRepo
    {

        public Task<List<Admins>> AllOperationalAdmins();
        public Task<Admins> AdminByAdminEmail(string Email);
        public Task<Admins> CheckLogin(string Email, string Password);
        public Task<Admins> AdminByAdminId(int AdminId);
        public Task<List<Admins>> AdminByAdminTypeId(int AdminTypeId);
        public Task<int> AdminRegistration(Admins admin);
        public Task<int> UpdateAdmin(Admins admin);
        public Task<int> DeleteAdmin(int AdminId);
    }
}

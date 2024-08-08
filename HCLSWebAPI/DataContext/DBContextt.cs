using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSWebAPI.DataContext
{
    public class DBContextt:DbContext
    {
        public DBContextt(DbContextOptions<DBContextt>options):base(options) { }

        public DbSet<AdminTypes>AdminType { get; set; }
        public DbSet<Admins>Admin {  get; set; }
    }   
}

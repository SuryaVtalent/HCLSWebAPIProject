using HCLSWebAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HCLSProjectTest.DataAccessTest.RepositoryTest;

namespace HCLSProjectTest.DataAccessTest.RepositoryTest
{
    [TestClass]
    public class HCLSRepTest
    {
        [TestMethod]
        public async Task TestAdminRegistration() 
        {
        //Arrange
        //create object to Insert the record values

            Admins admin=new Admins()

            { 
                AdminId=1001,
                Name="Surya",
                Gender="Male",
                Email="surya@gmail.com",
                Password="12345",
                Address="Hyd",
                Active=true,
                AdminTypeId=10
            
            
            };

            HCLSProjectRepo obj= new HCLSProjectRepo();



            //Act
            var ActualRes = await obj.AdminRegistration(admin);
            //Assert
            Assert.AreEqual(1,ActualRes);
         }

         [TestMethod]
         public async Task TestUpdateAdmin()
        {
            Admins admin1 = new Admins()
            {
                AdminId = 1001,
                Name = "Surya",
                Gender = "Male",
                Email = "surya@gmail.com",
                Password = "12345",
                Address = "Hyd",
                Active = true,
                AdminTypeId = 10

            };
            
            Admins admin2=new Admins() 
           {
                AdminId = 1001,
                Name = "Suryavardhan",
                Gender = "Male",
                Email = "suryavardhan@gmail.com",
                Password = "12345",
                Address = "Hyderabad",
                Active = true,
                AdminTypeId = 10

            };

                HCLSProjectRepo obj = new HCLSProjectRepo();
                await obj.AdminRegistration(admin1);

                var res = await obj.UpdateAdmin(admin2);

                Assert.AreEqual(1,res);
                Assert.AreEqual(1,obj.TotalRecords());
                Assert.IsNotNull(obj._db);

        }

        [TestMethod]
        public async Task DeleteAdmin()
        {
            Admins admin1 = new Admins()
            {
                AdminId = 1001,
                Name = "Surya",
                Gender = "Male",
                Email = "surya@gmail.com",
                Password = "12345",
                Address = "Hyd",
                Active = true,
                AdminTypeId = 10

            };

            Admins admin2 = new Admins()
            {
                AdminId = 1002,
                Name = "Greeshma",
                Gender = "Female",
                Email = "greeshma@gmail.com",
                Password = "12345",
                Address = "Delhi",
                Active = true,
                AdminTypeId = 20

            };

            HCLSProjectRepo obj = new HCLSProjectRepo();
            await obj.AdminRegistration(admin1);
            await obj.AdminRegistration(admin2);

            var res=await obj.DeleteAdmin(admin1.AdminId);

            Assert.AreEqual(1001,res);
            Assert.AreEqual(2, obj.TotalRecords());
            Assert.IsNotNull(obj._db);
            

        }

        [TestMethod]
        public async Task TestAllOperationalAdmins()
        {
            Admins admin1 = new Admins()
            {
                AdminId = 1001,
                Name = "Surya",
                Gender = "Male",
                Email = "surya@gmail.com",
                Password = "12345",
                Address = "Hyd",
                Active = true,
                AdminTypeId = 10

            };

            Admins admin2 = new Admins()
            {
                AdminId = 1002,
                Name = "Greeshma",
                Gender = "Female",
                Email = "greeshma@gmail.com",
                Password = "12345",
                Address = "Delhi",
                Active = true,
                AdminTypeId = 20

            };

            HCLSProjectRepo obj = new HCLSProjectRepo();
            await obj.AdminRegistration(admin1);
            await obj.AdminRegistration(admin2);

            var res = await obj.AllOperationalAdmins();

            Assert.IsNotNull(obj._db);
            Assert.AreEqual(2,res.Count);
        }

        [TestMethod]
        public async Task TestAdminByAdminEmail()
        {
            Admins admin1 = new Admins()
            {
                AdminId = 1001,
                Name = "Surya",
                Gender = "Male",
                Email = "surya@gmail.com",
                Password = "12345",
                Address = "Hyd",
                Active = true,
                AdminTypeId = 10

            };

            Admins admin2 = new Admins()
            {
                AdminId = 1002,
                Name = "Greeshma",
                Gender = "Female",
                Email = "greeshma@gmail.com",
                Password = "12345",
                Address = "Delhi",
                Active = true,
                AdminTypeId = 20

            };

            HCLSProjectRepo obj = new HCLSProjectRepo();
            await obj.AdminRegistration(admin1);
            await obj.AdminRegistration(admin2);

            var res = obj.AdminByAdminEmail(admin1.Email);

            Assert.IsNotNull(obj._db);
            Assert.AreEqual(2,obj.TotalRecords());
        }

        [TestMethod]
        public async Task TestCheckLogin()
        {
            Admins admin1 = new Admins()
            {
                AdminId = 1001,
                Name = "Surya",
                Gender = "Male",
                Email = "surya@gmail.com",
                Password = "12345",
                Address = "Hyd",
                Active = true,
                AdminTypeId = 10
            };

            Admins admin2 = new Admins()
            {
                AdminId = 1002,
                Name = "Greeshma",
                Gender = "Female",
                Email = "greeshma@gmail.com",
                Password = "12345",
                Address = "Chennai",
                Active = true,
                AdminTypeId = 10
            };

            HCLSProjectRepo obj = new HCLSProjectRepo();
            await obj.AdminRegistration(admin1);
            await obj.AdminRegistration(admin2);

            var res = obj.CheckLogin(admin1.Email,admin1.Password);

            Assert.IsNotNull(obj._db);
            Assert.AreEqual(2,obj.TotalRecords());


        }




    }
}

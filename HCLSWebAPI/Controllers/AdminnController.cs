using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminnController : ControllerBase
    {

        public IAdminRepo AdmRef;

        public AdminnController(IAdminRepo admRef)
        {
            AdmRef= admRef;
        }

        [HttpPost]
        [Route("AdminRegistration")]
        public async Task<IActionResult> AdminRegistration(Admins admin)
        {
            
                try
                {
                if (ModelState.IsValid)
                {

                    var count = await AdmRef.AdminRegistration(admin);
                    if (count > 0)
                    {
                        return Ok(count);
                    }
                    else
                    {
                        return BadRequest("Records not Registered");
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
                }
                
            catch (Exception e)
            {
                return BadRequest("Something went wrong "+e.Message+"Will resolve soon");
            }
        }

        [HttpGet]
        [Route("AllOperationalAdmins")]
        public async Task<IActionResult> AllOperationalAdmins()
        {
            try
            {
                var AdmList = await AdmRef.AllOperationalAdmins();
                if (AdmList.Count > 0)
                {
                    return Ok(AdmList);
                }
                else
                {
                    return BadRequest("Records not Found");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("AdminByAdminEmail")]
        public async Task<IActionResult> AdminByAdminEmail(string Email)
        {
            try
            {
                var Em = await AdmRef.AdminByAdminEmail(Email);
                if (Em !=null)
                {
                    return Ok(Em);
                }
                else
                {
                    return BadRequest("Records not Found");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("CheckLogin")]
        public async Task<IActionResult> CheckLogin(string Email, string Password)
        {
            try
            {
                var AdmList = await AdmRef.CheckLogin(Email,Password);
                if (AdmList.Count > 0)
                {
                    return Ok(AdmList);
                }
                else
                {
                    return BadRequest("Records not Found");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }


        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin(Admins admin)
        {
            try
            {
                var count = await AdmRef.UpdateAdmin(admin);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records not Registered");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int AdminId)
        {
            try
            {
                var count = await AdmRef.DeleteAdmin(AdminId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records not Registered");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }


    }
}

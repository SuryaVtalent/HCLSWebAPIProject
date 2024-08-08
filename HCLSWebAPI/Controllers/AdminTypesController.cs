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
    public class AdminTypesController : ControllerBase
    {

        public IAdmintypeRepo AdmRef;

        public AdminTypesController(IAdmintypeRepo _AdmRef)
        {
            AdmRef= _AdmRef;
        }

        [HttpPost]
        [Route("InsertAdminType")]
        public async Task<IActionResult> InsertAdminType(AdminTypes Adminty)
        {
            try
            {
               var count=await AdmRef.InsertAdminType(Adminty);
                if (count>0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are not Inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("AllAdminTypes")]
        public async Task<IActionResult> AllAdminTypes()
        {
            try
            {
                var AdmList = await AdmRef.AllAdminTypes();
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
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetAdminTypeById")]
        public async Task<IActionResult> GetAdminTypeById(int AdminTypeId)
        {
            try
            {
                var Adm = await AdmRef.GetAdminTypeById(AdminTypeId);
                if (Adm !=null)
                {
                    return Ok(Adm);
                }
                else
                {
                    return BadRequest("Records not Found");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetAdminTypeByName")]
        public async Task<IActionResult> GetAdminTypeByName(string AdminTypeName)
        {
            try
            {
                var AdmList = await AdmRef.GetAdminTypeByName(AdminTypeName);
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
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpPut]
        [Route("UpdateAdminType")]
        public async Task<IActionResult> UpdateAdminType(AdminTypes Adminty)
        {
            try
            {
                var count = await AdmRef.UpdateAdminType(Adminty);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are not Updated");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteAdminType")]
        public async Task<IActionResult> DeleteAdminType(int AdminTypeId)
        {
            try
            {
                var count = await AdmRef.DeleteAdminType(AdminTypeId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are not Inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

    }
}

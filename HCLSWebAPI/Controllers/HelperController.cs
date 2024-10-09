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
    public class HelperController : ControllerBase
    {
        public IHelperRepo HelRef;

        public HelperController(IHelperRepo helRef)
        {
            HelRef = helRef;
        }


        [HttpPost]
        [Route("InsertHelper")]
        public async Task<IActionResult> InsertHelper(Helper helper)
        {
            try
            {
               var count=await HelRef.InsertHelper(helper);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong"+e.Message+"will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetAllHelperDetails")]
        public async Task<IActionResult> GetAllHelperDetails()
        {
            try
            {
                var HelpList = await HelRef.GetAllHelperDetails();
                if (HelpList.Count > 0)
                {
                    return Ok(HelpList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetHelperById")]
        public async Task<IActionResult> GetHelperById(int HelpId)
        {
            try
            {
                var Help = await HelRef.GetHelperById(HelpId);
                if (Help !=null)
                {
                    return Ok(Help);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }


        [HttpGet]
        [Route("GetHelperByDeptNo")]
        public async Task<IActionResult> GetHelperByDeptNo(int DeptNo)
        {
            try
            {
                var HelpList = await HelRef.GetHelperByDeptNo( DeptNo);
                if (HelpList.Count>0)
                {
                    return Ok(HelpList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }

        [HttpGet]
        [Route("CheckLogin")]
        public async Task<IActionResult> CheckLogin(string Email, string Password)
        {
            try
            {
                var Help = await HelRef.CheckLogin(Email,Password);
                if (Help != null)
                {
                    return Ok(Help);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }



        [HttpPut]
        [Route("UpdateHelper")]
        public async Task<IActionResult> UpdateHelper(Helper helper)
        {
            try
            {
                var count = await HelRef.UpdateHelper(helper);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Updated");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteHelper")]
        public async Task<IActionResult> DeleteHelper(int HelpId)
        {
            try
            {
                var count = await HelRef.DeleteHelper( HelpId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Deleted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }




    }
}

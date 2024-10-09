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
    public class LabController : ControllerBase
    {
        public ILabRepo LabRef;

        public LabController(ILabRepo labRef)
        {
            LabRef = labRef;
        }

        [HttpPost]
        [Route("InsertLab")]
        public async Task<IActionResult> InsertLab(Lab lab)
        {
            try
            {
               var count=await LabRef.InsertLab(lab);
                if (count>0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong"+e.Message+"Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetAllLabDetails")]
        public async Task<IActionResult> GetAllLabDetails()
        {
            try
            {
                var LabList = await LabRef.GetAllLabDetails();
                if (LabList.Count > 0)
                {
                    return Ok(LabList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetLabId")]
        public async Task<IActionResult> GetLabId(int LabId)
        {
            try
            {
                var lab = await LabRef.GetLabId(LabId);
                if (lab !=null)
                {
                    return Ok(lab);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }


        [HttpGet]
        [Route("GetLabByDeptNo")]
        public async Task<IActionResult> GetLabByDeptNo(int DeptNo)
        {
            try
            {
                var DLabList = await LabRef.GetLabByDeptNo(DeptNo);
                if (DLabList.Count>0)
                {
                    return Ok(DLabList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }


        [HttpGet]
        [Route("CLogin")]
        public async Task<IActionResult> CLogin(string Email, string Password)
        {
            try
            {
                var lab = await LabRef.CLogin(Email,Password);
                if (lab != null)
                {
                    return Ok(lab);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpPut]
        [Route("UpdateLab")]
        public async Task<IActionResult> UpdateLab(Lab lab)
        {
            try
            {
                var count = await LabRef.UpdateLab(lab);
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
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteLab")]
        public async Task<IActionResult> DeleteLab(int LabId)
        {
            try
            {
                var count = await LabRef.DeleteLab(LabId);
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
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }


    }
}

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
    public class PatientStatusController : ControllerBase
    {

        public IPatientStatusRepo Patref;

        public PatientStatusController(IPatientStatusRepo patref)
        {
            Patref = patref;
        }

        [HttpPost]
        [Route("Insertpatientstatus")]
        public async Task<IActionResult> Insertpatientstatus(PatientStatus patientStatus)
        {
            try
            {
               var count=await Patref.Insertpatientstatus(patientStatus);
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
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }


        [HttpGet]
        [Route("GetAllPatientStatus")]
        public async Task<IActionResult> GetAllPatientStatus()
        {
            try
            {
                var PatList = await Patref.GetAllPatientStatus();
                if (PatList.Count > 0)
                {
                    return Ok(PatList);
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
        [Route("GetPatientStatusId")]
        public async Task<IActionResult> GetPatientStatusId(int StatId)
        {
            try
            {
                var Pat = await Patref.GetPatientStatusId(StatId);
                if (Pat !=null)
                {
                    return Ok(Pat);
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
        [Route("Updatepatientstatus")]
        public async Task<IActionResult> Updatepatientstatus(PatientStatus patientStatus)
        {
            try
            {
                var count = await Patref.Updatepatientstatus(patientStatus);
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

        [HttpPost]
        [Route("Deletepatientstatus")]
        public async Task<IActionResult> Deletepatientstatus(int StatId)
        {
            try
            {
                var count = await Patref.Deletepatientstatus(StatId);
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

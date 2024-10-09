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
    public class PatientController : ControllerBase
    {

        public IPatientRepo PatiRef;
        public PatientController(IPatientRepo patiRef)
        {
            PatiRef = patiRef;
        }

        [HttpPost]
        [Route("InsertPatient")]
        public async Task<IActionResult> InsertPatient(Patient patient)
        {
            try
            {
               var count=await PatiRef.InsertPatient(patient);
                if (count > 0)
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
        [Route("GetAllPatientDetails")]
        public async Task<IActionResult> GetAllPatientDetails()
        {
            try
            {
                var PatientList = await PatiRef.GetAllPatientDetails();
                if (PatientList.Count > 0)
                {
                    return Ok(PatientList);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientById")]
        public async Task<IActionResult> GetPatientById(int PatientId)
        {
            try
            {
                var Pati = await PatiRef.GetPatientById(PatientId);
                if (Pati !=null)
                {
                    return Ok(Pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientByEmailandPassword")]
        public async Task<IActionResult> GetPatientByEmailandPassword(string Email, string Password)
        {
            try
            {
                var Pati = await PatiRef.GetPatientByEmailandPassword(Email,Password);
                return Ok(Pati);
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientbyDocSpecId")]
        public async Task<IActionResult> GetPatientbyDocSpecId(int DocSpecId)
        {
            try
            {
                var pati = await PatiRef.GetPatientbyDocSpecId(DocSpecId);
                if (pati !=null)
                {
                    return Ok(pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientByRecpId")]
        public async Task<IActionResult> GetPatientByRecpId(int RecpId)
        {
            try
            {
                var pati = await PatiRef.GetPatientByRecpId(RecpId);
                if (pati !=null)
                {
                    return Ok(pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientByHelpId")]
        public async Task<IActionResult> GetPatientByHelpId(int HelpId)
        {
            try
            {
                var pati = await PatiRef.GetPatientByHelpId(HelpId);
                if (pati !=null)
                {
                    return Ok(pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientByDocId")]
        public async Task<IActionResult> GetPatientByDocId(int DocId)
        {
            try
            {
                var Pati = await PatiRef.GetPatientByDocId(DocId);
                if (Pati !=null)
                {
                    return Ok(Pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientByLabId")]
        public async Task<IActionResult> GetPatientByLabId(int LabId)
        {
            try
            {
                var Pati = await PatiRef.GetPatientByLabId(LabId);
                if (Pati !=null)
                {
                    return Ok(Pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetPatientByStatId")]
        public async Task<IActionResult> GetPatientByStatId(int StatId)
        {
            try
            {
                var Pati = await PatiRef.GetPatientByStatId(StatId);
                if (Pati !=null)
                {
                    return Ok(Pati);
                }
                else
                {
                    return NotFound("Records are not Avaialble");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }



        [HttpPut]
        [Route("UpdatePatient")]
        public async Task<IActionResult> UpdatePatient(Patient patient)
        {
            try
            {
                var count = await PatiRef.UpdatePatient(patient);
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
        [Route("DeletePatient")]
        public async Task<IActionResult> DeletePatient(int PatientId)
        {
            try
            {
                var count = await PatiRef.DeletePatient(PatientId);
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

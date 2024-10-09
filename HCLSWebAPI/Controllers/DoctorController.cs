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
    public class DoctorController : ControllerBase
    {
        public IDocRepo DocRef;
        public DoctorController(IDocRepo docRef)
        {
            DocRef = docRef;
        }

        [HttpPost]
        [Route("InsertDoctor")]
        public async Task<IActionResult> InsertDoctor(Doctor doctor)
        {
            try
            {
               var count=await DocRef.InsertDoctor(doctor);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are Not Inserted");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong "+e.Message+"Will resolve soon");
            }
        }

        [HttpGet]
        [Route("AllDoctors")]
        public async Task<IActionResult> AllDoctors()
        {
            try
            {
                var DocList = await DocRef.AllDoctors();
                if (DocList.Count > 0)
                {
                    return Ok(DocList);
                }
                else
                {
                    return NotFound("Records are Not Available");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetDoctorById")]
        public async Task<IActionResult> GetDoctorById(int DocId)
        {
            try
            {
                var Doc = await DocRef.GetDoctorById(DocId);
                if (Doc !=null)
                {
                    return Ok(Doc);
                }
                else
                {
                    return NotFound("Records are Not Available");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetDoctorByDeptNo")]
        public async Task<IActionResult> GetDoctorByDeptNo(int DeptNo)
        {
            try
            {
                var DocList = await DocRef.GetDoctorByDeptNo(DeptNo);
                if (DocList.Count > 0)
                {
                    return Ok(DocList);
                }
                else
                {
                    return NotFound("Records are Not Available");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }
        [HttpGet]
        [Route("GetDoctorByDocSpecId")]
        public async Task<IActionResult> GetDoctorByDocSpecId(int DocSpecId)
        {
            try
            {
                var DocList = await DocRef.GetDoctorByDocSpecId(DocSpecId);
                if (DocList.Count > 0)
                {
                    return Ok(DocList);
                }
                else
                {
                    return NotFound("Records are Not Available");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetDocByEmailandPassword")]
        public async Task<IActionResult> GetDocByEmailandPassword(string Email, string Password)
        {
            try
            {
                var Doc = await DocRef.GetDocByEmailandPassword(Email,Password);
                if (Doc != null)
                {
                    return Ok(Doc);
                }
                else
                {
                    return NotFound("Records are Not Available");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpPut]
        [Route("UpdateDoctor")]
        public async Task<IActionResult> UpdateDoctor(Doctor doctor)
        {
            try
            {
                var count = await DocRef.UpdateDoctor(doctor);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are Not Updated");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteDoctor")]
        public async Task<IActionResult> DeleteDoctor(int DocId)
        {
            try
            {
                var count = await DocRef.DeleteDoctor(DocId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are Not Deleted");
                }

            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }
    }
}

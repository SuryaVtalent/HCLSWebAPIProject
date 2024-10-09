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
    public class DocSpecController : ControllerBase
    {
        public IDocSpecRepo DocSpecRef;

        public DocSpecController(IDocSpecRepo docSpecRef)
        {
            DocSpecRef = docSpecRef;
        }

        [HttpPost]
        [Route("InsertDocSpec")]
        public async Task<IActionResult> InsertDocSpec(DoctorSpecialization docspec)
        {
            try
            {
               var count=await DocSpecRef.InsertDocSpec(docspec);
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
                return BadRequest("Somethng went wrong "+e.Message+"Will resolve soon");
            }
        }

        [HttpGet]
        [Route("AllDocSpecDetails")]
        public async Task<IActionResult> AllDocSpecDetails()
        {
            try
            {
                var DocSpecList = await DocSpecRef.AllDocSpecDetails();
                if (DocSpecList.Count > 0)
                {
                    return Ok(DocSpecList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Somethng went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetDocSpecById")]
        public async Task<IActionResult> GetDocSpecById(int DocSpecId)
        {
            try
            {
                var DocSpec = await DocSpecRef.GetDocSpecById(DocSpecId);
                if (DocSpec !=null)
                {
                    return Ok(DocSpec);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Somethng went wrong " + e.Message + "Will resolve soon");
            }
        }

        

        [HttpPut]
        [Route("UpdateDocSpec")]
        public async Task<IActionResult> UpdateDocSpec(DoctorSpecialization docspec)
        {
            try
            {
                var count = await DocSpecRef.UpdateDocSpec(docspec);
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
                return BadRequest("Somethng went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteDocSpec")]
        public async Task<IActionResult> DeleteDocSpec(int DocSpecId)
        {
            try
            {
                var count = await DocSpecRef.DeleteDocSpec(DocSpecId);
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
                return BadRequest("Somethng went wrong " + e.Message + "Will resolve soon");
            }
        }

    }
}

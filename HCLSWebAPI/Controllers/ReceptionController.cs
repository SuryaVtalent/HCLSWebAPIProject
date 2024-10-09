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
    public class ReceptionController : ControllerBase
    {
        public IReceptionRepo RecRef;

        public ReceptionController(IReceptionRepo recRef)
        {
            RecRef = recRef;
        }

        [HttpPost]
        [Route("InsertReception")]
        public async Task<IActionResult> InsertReception(Receptionist receptionist)
        {
            try
            {
               var count=await RecRef.InsertReception(receptionist);
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
                return BadRequest("Something went wrong"+e.Message+"will resolve soon");
            }
        }

        [HttpGet]
        [Route("AllReceptionDetails")]
        public async Task<IActionResult> AllReceptionDetails()
        {
            try
            {
                var Reclist = await RecRef.AllReceptionDetails();
                if (Reclist.Count > 0)
                {
                    return Ok(Reclist);

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
        [Route("GetReceptionById")]
        public async Task<IActionResult> GetReceptionById(int RecpId)
        {
            try
            {
                var Rec = await RecRef.GetReceptionById( RecpId);
                if (Rec != null)
                {
                    return Ok(Rec);

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
        [Route("GetReceptionByDeptId")]
        public async Task<IActionResult> GetReceptionByDeptId(int DeptNo)
        {
            try
            {
                var RecList = await RecRef.GetReceptionByDeptId( DeptNo);
                if (RecList.Count>0)
                {
                    return Ok(RecList);

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
        [Route("GetReceptionByEmailandPassword")]
        public async Task<IActionResult> GetReceptionByEmailandPassword(string Email, string Password)
        {
            try
            {
                var Rec = await RecRef.GetReceptionByEmailandPassword(Email,Password);
                return Ok(Rec);
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }




        [HttpPut]
        [Route("UpdateReception")]
        public async Task<IActionResult> UpdateReception(Receptionist receptionist)
        {
            try
            {
                var count = await RecRef.UpdateReception(receptionist);
                if (count > 0)
                {
                    return Ok(count);

                }
                else
                {
                    return NotFound("Records are Inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "will resolve soon");
            }
        }


        [HttpDelete]
        [Route("DeleteReception")]
        public async Task<IActionResult> DeleteReception(int RecpId)
        {
            try
            {
                var count = await RecRef.DeleteReception(RecpId);
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

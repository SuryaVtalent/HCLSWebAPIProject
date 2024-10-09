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
    public class DepartmentController : ControllerBase
    {
        public IDeptRepo DptRef;

        public DepartmentController(IDeptRepo dptRef)
        {
            DptRef = dptRef;
        }

        [HttpPost]
        [Route("InsertDept")]
        public async Task<IActionResult> InsertDept(Department dept)
        {
            try
            {
               var count=await DptRef.InsertDept(dept);
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
        [Route("AllDepartments")]

        public async Task<IActionResult> AllDepartments()
        {
            try
            {
               var DeptList=await DptRef.AllDepartments();
                if (DeptList.Count > 0)
                {
                    return Ok(DeptList);
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
        [Route("GetDeptById")]

        public async Task<IActionResult> GetDeptById(int DeptId)
        {
            try
            {
                var Dpt = await DptRef.GetDeptById(DeptId);
                if (Dpt !=null)
                {
                    return Ok(Dpt);
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
        [Route("UpdateDept")]
        public async Task<IActionResult> UpdateDept(Department dept)
        {
            try
            {
                var count = await DptRef.UpdateDept(dept);
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

        [HttpGet]
        [Route("DeleteDept")]
        public async Task<IActionResult> DeleteDept(int DeptId)
        {
            try
            {
                var count = await DptRef.DeleteDept(DeptId);
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

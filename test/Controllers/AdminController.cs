using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;
using test.Models;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> EmployeesAdd([FromBody] Employee employee)
        {
            if(employee != null) 
            {
           _db.Employees.Add(employee);
           _db.SaveChanges();
            return Ok();
            }
            else
            {
                return BadRequest("Employee is null");
            }
          
            
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreApisProject.Models;
using Microsoft.EntityFrameworkCore;
namespace CoreApisProject.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        CollegedbContext db;
        public StudentApiController(CollegedbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        [Route("api/student")]
        public async Task< List<Student>> GetAll()
        {
            return await db.Students.ToListAsync();
        }
        [HttpGet]
        [Route("api/student/{id}")]
        public async Task<Student>  GetById(int id)
        {
            return await db.Students.FindAsync(id);
        }
    }
}

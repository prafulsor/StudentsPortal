using StudentsPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace StudentsPortal.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    { 
       
        public StudentsController(StudentssystemContext context)
        {
            _context = context;
        }
        public StudentssystemContext _context { get; }


        [HttpGet("GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetAllStudentsData()
        {

            return _context.Students.ToList();
           
        }

    }
}

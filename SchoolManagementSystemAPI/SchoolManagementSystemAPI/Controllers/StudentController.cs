using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystemServiceLayer;
using SchoolManagmentSystemDomainLayer.Model;
using Student = SchoolManagmentSystemDomainLayer.Model.Student;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentService _studentsvc;
        public readonly ILogger<StudentController> _logger;

        public StudentController(IStudentService student, ILogger<StudentController> logger) 
        {
            _studentsvc = student;
            _logger = logger;
        }
        // GET: api/<StudentController>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllStudent()
        {
            var student = await _studentsvc.GetStudentList();
            try
            {
                if (student == null) 
                    return NotFound();
                _logger.LogInformation("Get Student Completeed");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.InnerException.Message);
                return BadRequest();
            }
            return Ok(student);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public  IActionResult Post(Student student)
        {
            try
            {
                _studentsvc.AddStudent(student);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.InnerException.Message);
                return BadRequest();
            }
            return Ok();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

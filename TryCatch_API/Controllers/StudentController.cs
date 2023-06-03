using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TryCatch_API.Controllers
{
    //https:/localhost:portnumber/api/Student
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static string[] students = new string[] { "Sonam", "Praveen", "Pathan", "Harsh" };
        [HttpGet]
        public IActionResult GetAllStudent()       
        {
            return Ok(students);
        }
        [Route("GetStd")]
        [HttpGet ]
        public IActionResult GetStudent()
        {
            return Ok(students);
        }
        [HttpPost]
        public IActionResult InsertStudent(string SName)
        {
            string[] StudentName = new string[] { SName };
            students= students.Concat(StudentName).ToArray();
            return Ok(students);
        }
        [HttpPut]
        public IActionResult UpdateStudent(int Index,string UpdatedName)
        {
            students[Index]= UpdatedName;
            return Ok(students);
        }
        [HttpDelete]
        public IActionResult DeleteStudent(string SName)
        {
            students=students.Where(x => x!=SName).ToArray();
            return Ok(students);
        }
    }
}

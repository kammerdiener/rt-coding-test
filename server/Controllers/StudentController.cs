using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Interfaces;
using server.Model;
using server.Infrastructure;
using System;
using System.Collections.Generic;

namespace server.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class StudentController : Controller
    {
        private readonly StudentRepository _studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [noCache]

        // GET /api/
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _studentRepository.GetAllStudents(); // TODO: Add the pagination pieces
        }

        // GET /api/${id}
        [HttpGet("{id}")]
        public async Task<Student> Get(string id)
        {
            return await _studentRepository.GetStudent(id); // TODO: Add something so that if there is no student it returns a proper error
        }

        // POST /api/
        [HttpPost]
        public void Post([FromBody] StudentParam newStudent)
        {
            // TODO: Validation of items passed in
            _studentRepository.AddStudent(new Student{
                Name = newStudent.name, 
                StudentId = newStudent.studentId,
                Grade = newStudent.grade
            });
        }

        // PUT /api/${id}
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]string value)
        {
            // TODO: Validation of items passed in
            _studentRepository.UpdateStudent(id, value);
        }

        // DELETE /api/${id}
        [HttpDelete("${id}")]
        public void Delete(string id)
        {
            _studentRepository.RemoveStudent(id); 
        }
    }
}
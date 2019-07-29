using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using server.Model;

namespace server.Interfaces
{
    public interface StudentRepository
    {
        // GET all the students (GET)
        Task<IEnumerable<Student>> GetAllStudents();

        // GET a student (GET)
        Task<Student> GetStudent(string id);

        // add new student (POST)
        Task AddStudent(Student item);

        // remove a single student (DELETE)
        Task<bool> RemoveStudent(string id);

        // update just a single student (PUT)
        Task<bool> UpdateStudent(string id, string body);
    }
}
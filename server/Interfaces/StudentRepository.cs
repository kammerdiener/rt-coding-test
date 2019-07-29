using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using server.Model;

namespace server.Interfaces
{
    public interface StudentRepository
    {
        // get all the students
        Task<IEnumerable<Student>> GetAllStudents();

        // get a student
        Task<Student> GetStudent(string id);

        // add new student
        Task AddStudent(Student item);

        // remove a single student
        Task<bool> RemoveStudent(string id);

        // update just a single student
        Task<bool> UpdateStudent(string id, string body);
    }
}
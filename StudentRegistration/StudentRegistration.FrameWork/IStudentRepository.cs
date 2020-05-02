using StudentRegistration.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.Framework
{
    public interface IStudentRepository : IRepository<Student, int, FrameworkContext>
    {
        IList<Student> GetLatestStudents();
    }
}

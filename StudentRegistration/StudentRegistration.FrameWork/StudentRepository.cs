using StudentRegistration.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentRegistration.Framework
{
    public class StudentRepository : Repository<Student, int, FrameworkContext>, IStudentRepository
    {
        public StudentRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Student> GetLatestStudents()
        {
            return Get(x => x.PublicationDate < DateTime.Now.AddDays(-7)).ToList();
        }
    }
}

using StudentRegistration.Data;
using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public interface ICourseRepository : IRepository<Course, int, FrameworkContext>
    {
        IList<Course> GetLatestCourses();
    }
}

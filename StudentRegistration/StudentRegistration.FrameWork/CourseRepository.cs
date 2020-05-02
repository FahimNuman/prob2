using StudentRegistration.Data;
using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class CourseRepository : Repository<Course, int, FrameworkContext>, ICourseRepository
    {
        public CourseRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Course> GetLatestCourses()
        {
            return Get(x => x.PublicationDate < DateTime.Now.AddDays(-7)).ToList();
        }
    }
}

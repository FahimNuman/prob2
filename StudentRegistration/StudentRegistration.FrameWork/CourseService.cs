using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class CourseService : ICourseService, IDisposable
    {
        private ICourseUnitOfWork _courseUnitOfWork;

        public CourseService(ICourseUnitOfWork courseUnitOfWork)
        {
            _courseUnitOfWork = courseUnitOfWork;
        }

        public void CreateCourse(Course course)
        {
            _courseUnitOfWork.CourseRepositroy.Add(course);
            _courseUnitOfWork.Save();
        }

        public void Dispose()
        {
            _courseUnitOfWork?.Dispose();
        }

        public (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _courseUnitOfWork.CourseRepositroy.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}

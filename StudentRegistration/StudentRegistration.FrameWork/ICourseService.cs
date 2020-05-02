using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public interface ICourseService : IDisposable
    {
        (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
        void CreateCourse(Course course);
    }
}

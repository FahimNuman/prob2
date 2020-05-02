using StudentRegistration.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public interface ICourseUnitOfWork : IUnitOfWork
    {
        ICourseRepository CourseRepositroy { get; set; }

    }
}

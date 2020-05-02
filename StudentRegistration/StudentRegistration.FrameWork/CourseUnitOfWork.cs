using StudentRegistration.Data;
using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class CourseUnitOfWork : UnitOfWork, ICourseUnitOfWork
    {
        public ICourseRepository CourseRepositroy { get; set; }

        public CourseUnitOfWork(FrameworkContext context, ICourseRepository courseRepositroy)
            : base(context)
        {
            CourseRepositroy = courseRepositroy;

        }
    }
}


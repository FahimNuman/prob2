using Autofac;
using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Areas.Admin.Models
{
    public class CourseBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly ICourseService _courseService;
        public CourseBaseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public CourseBaseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public void Dispose()
        {
            _courseService?.Dispose();
        }
    }
}

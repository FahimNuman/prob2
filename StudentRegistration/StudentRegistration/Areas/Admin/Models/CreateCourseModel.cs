using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Areas.Admin.Models
{
    public class CreateCourseModel : CourseBaseModel
    {
        public string Title { get; set; }
     

        public CreateCourseModel(ICourseService courseService) : base(courseService) { }
        public CreateCourseModel() : base() { }

        public void Create()
        {
            var course = new Course
            {
                Title = this.Title,
                //PublicationDate = DateTime.Now

            };

            _courseService.CreateCourse(course);
        }
    }
}
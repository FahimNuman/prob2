using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Areas.Admin.Models
{
    public class CourseModel : CourseBaseModel
    {
        public CourseModel(ICourseService courseService) : base(courseService) { }
        public CourseModel() : base() { }

        internal object GetCourses(DataTablesAjaxRequestModel tableModel)
        {
            var data = _courseService.GetCourses(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "PublicationDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Title,
                                record.PublicationDate.ToString()

                        }
                    ).ToArray()

            };
        }
    }
}

using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Areas.Admin.Models
{
    public class StudentModel : StudentBaseModel
    {
        public StudentModel(IStudentService studentService) : base(studentService) { }
        public StudentModel() : base() { }

        internal object GetStudents(DataTablesAjaxRequestModel tableModel)
        {
            var data = _studentService.GetStudents(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Title,
                                record.Author,
                                record.Edition,
                                record.PublicationDate.ToString()
                        }
                    ).ToArray()

            };
        }
    }
}

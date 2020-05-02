using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Areas.Admin.Models
{
    public class CreateStudentModel : StudentBaseModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }

        public CreateStudentModel(IStudentService studentService) : base(studentService) { }
        public CreateStudentModel() : base() { }

        public void Create()
        {
            var student = new Student
            {
                Title = this.Title,
                Author = this.Author,
                Edition = this.Edition,
                PublicationDate = DateTime.Now
            };

            _studentService.CreateStudent(student);
        }
    }
}
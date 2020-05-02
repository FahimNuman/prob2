using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentRegistration.Framework
{
    public class StudentService : IStudentService, IDisposable
    {
        private ILibraryUnitOfWork _libraryUnitOfWork;

        public StudentService(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        public void CreateStudent(Student student)
        {
            _libraryUnitOfWork.StudentRepositroy.Add(student);
            _libraryUnitOfWork.Save();
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.StudentRepositroy.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}

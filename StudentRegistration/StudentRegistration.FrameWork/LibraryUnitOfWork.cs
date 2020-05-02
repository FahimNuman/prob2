using StudentRegistration.Data;
using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.Framework
{
    public class LibraryUnitOfWork : UnitOfWork, ILibraryUnitOfWork
    {
        public IStudentRepository StudentRepositroy { get; set; }
        
        public LibraryUnitOfWork(FrameworkContext context, IStudentRepository studentRepositroy)
            : base(context)
        {
            StudentRepositroy = studentRepositroy;
            
        }
    }
}

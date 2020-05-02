using StudentRegistration.Data;
using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.Framework
{
    public interface ILibraryUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepositroy { get; set; }
        
    }
}

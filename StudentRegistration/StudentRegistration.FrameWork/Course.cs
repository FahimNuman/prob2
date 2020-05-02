using StudentRegistration.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class Course : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; internal set; }
    }
}

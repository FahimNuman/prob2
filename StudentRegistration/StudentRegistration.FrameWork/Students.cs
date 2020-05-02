using StudentRegistration.Data;
using System;

namespace StudentRegistration.Framework
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }
    }
}

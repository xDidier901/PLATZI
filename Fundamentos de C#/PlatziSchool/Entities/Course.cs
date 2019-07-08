using System;
using System.Collections.Generic;

namespace PlatziSchool.Entities
{
    public class Course
    {
        public string Id { get; }
        public string Name { get; set; }
        public ShiftTypes ShiftType { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public Course()
        {
            Id = Guid.NewGuid().ToString();
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
    }
}
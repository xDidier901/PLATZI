using System;
using System.Collections.Generic;

namespace PlatziSchool.Entities
{
    public class Student
    {
        public string Id { get; }
        public string Name { get; set; }
        public List<Test> Tests { get; set; }
        public Student() => (Id, Tests) = (Guid.NewGuid().ToString(), Tests = new List<Test>());
    }
}
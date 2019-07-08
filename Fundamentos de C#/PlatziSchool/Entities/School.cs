using System;
using System.Collections.Generic;

namespace PlatziSchool.Entities
{
    public class School
    {
        public string Id { get; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Course> Courses { get; set; }
        public School() => (Id, Courses) = (Guid.NewGuid().ToString(), Courses = new List<Course>());

        public override string ToString()
        {
            return $"School Name: {Name}\nCity: {City}\nCreation Date: {CreationDate.ToLongDateString()}";
        }
    }
}
using System;

namespace PlatziSchool.Entities
{
    public class Test
    {
        public string Id { get; }
        public string Name { get; set; }
        public float Score { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public Test() => Id = Guid.NewGuid().ToString();
    }
}
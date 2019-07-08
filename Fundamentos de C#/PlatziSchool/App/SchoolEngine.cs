using System;
using System.Collections.Generic;
using System.Linq;
using PlatziSchool.Entities;
using static System.Console;

namespace PlatziSchool.App
{
    public class SchoolEngine
    {
        School school;
        public void Initialize()
        {
            school = new School
            {
                Name = "PlatziSchool",
                City = "Hermosillo",
                Country = "México",
                CreationDate = DateTime.Now,
                SchoolType = SchoolTypes.MiddleSchool
            };
            school.Courses.AddRange(LoadCourses());
            LoadSubjects(school);

            foreach (var course in school?.Courses)
            {
                course.Students = LoadStudents(new Random().Next(15, 40));
            }

            LoadTests();

            WriteLine(school);
        }

        public List<Course> LoadCourses()
        {
            return new List<Course>{
                new Course{Name="101",ShiftType = ShiftTypes.Morning},
                new Course{Name="102",ShiftType = ShiftTypes.Morning},
                new Course{Name="103",ShiftType = ShiftTypes.Morning},
                new Course{Name="104",ShiftType = ShiftTypes.Morning},
                new Course{Name="105",ShiftType = ShiftTypes.Morning},
                new Course{Name="111",ShiftType = ShiftTypes.Afternoon},
                new Course{Name="112",ShiftType = ShiftTypes.Afternoon},
                new Course{Name="113",ShiftType = ShiftTypes.Afternoon},
                new Course{Name="114",ShiftType = ShiftTypes.Afternoon},
                new Course{Name="115",ShiftType = ShiftTypes.Afternoon},
                new Course{Name="121",ShiftType = ShiftTypes.Night},
                new Course{Name="122",ShiftType = ShiftTypes.Night},
                new Course{Name="123",ShiftType = ShiftTypes.Night},
                new Course{Name="124",ShiftType = ShiftTypes.Night},
                new Course{Name="125",ShiftType = ShiftTypes.Night}
           };
        }

        public List<Student> LoadStudents(int quantity)
        {
            string[] name = { "Cesar", "Francisco", "Joel", "David", "Carlos" };
            string[] lastName = { "Valdez", "Encinas", "García", "Rivera", "Medonza" };

            return (from n in name
                    from l in lastName
                    select new Student { Name = $"{n} {l}" })
                    .OrderBy(x => x.Id).Take(quantity).ToList();
        }

        public void LoadTests()
        {
            school.Courses.ForEach(course =>
            {
                course.Subjects.ForEach(subject =>
                {
                    course.Students.ForEach(student =>
                    {
                        var random = new Random();
                        student.Tests.AddRange(
                            new List<Test>{
                                new Test{
                                    Name =$"{course.Name}-{subject.Name} First Evaluation",
                                    Student = student,
                                    Subject = subject,
                                    Score = (float)(random.NextDouble()*5)
                                    },
                                new Test{
                                    Name =$"{course.Name}-{subject.Name} Mid Evaluation",
                                    Student = student,
                                    Subject = subject,
                                    Score = (float)(random.NextDouble()*5)
                                    },
                                new Test{
                                    Name =$"{course.Name}-{subject.Name} Final Evaluation",
                                    Student = student,
                                    Subject = subject,
                                    Score = (float)(random.NextDouble()*5)
                                    }
                        });
                    });
                });
            });
        }

        public void LoadSubjects(School school)
        {
            foreach (var course in school?.Courses)
            {
                course.Subjects.AddRange(
                    new List<Subject>{
                        new Subject {
                            Name="Programming"
                        },
                        new Subject
                        {
                            Name = "History"
                        },
                        new Subject
                        {
                            Name = "Math"
                        }
                    }
                );
            }
        }

    }
}
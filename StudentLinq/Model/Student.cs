using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinq.Model
{
    public class Student
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();
        public List<Course> CoursesTaken { get; set; } = new List<Course>();

        public override string ToString()
        {
            return $"{FirstName} {LastName},\t({Email}),\tno. of exams: {Exams.Count},\tno. of courses {CoursesTaken.Count}";
        }
    }
}


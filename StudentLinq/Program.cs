using System;
using System.Linq;

namespace StudentLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All students");
            DataAccess.GetAllStudents().ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            
            Console.WriteLine("Firstname of all students");
            DataAccess.GetAllStudents().Select(student => student.FirstName).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            
            Console.WriteLine("All students, sorted by last name");
            DataAccess.GetAllStudents().OrderBy(student => student.LastName).Select(student => student.LastName).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            
            Console.WriteLine("All students, sorted descending by number of courses taken");
            DataAccess.GetAllStudents().OrderByDescending(student => student.CoursesTaken.Count).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();


            Console.WriteLine("Email addresses of all students who have scored 100 on a test");
            DataAccess.GetAllStudents().Where(student => student.Exams.Any(exam => exam.Score >= 100)).Select(student => student.Email).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("All students who have an average above 75 on their tests");
            DataAccess.GetAllStudents().Where(student => student.Exams.Average(exam => exam.Score) >= 75).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();


            Console.WriteLine("Firstname and average from all students who have an average above 75 on their tests");
            DataAccess.GetAllStudents().Where(student => student.Exams.Average(exam => exam.Score) >= 75).Select(student => new { FirstName = student.FirstName, Avarage = student.Exams.Average(exam => exam.Score) }).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();


            Console.WriteLine("All students who have taken an intermediate/advanced class (one without '101' in the name)");
            DataAccess.GetAllStudents().Where(student => student.CoursesTaken.Any(course => !course.Name.Contains("101"))).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

        }
    }
}
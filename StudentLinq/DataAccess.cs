using StudentLinq.Model;
using System;
using System.Collections.Generic;

namespace StudentLinq
{
    public static class DataAccess
    {

        #region Courses
        private static readonly Course physics101       = new Course() { Name = "Physics 101",      Subject = Subject.Physics };
        private static readonly Course physics201       = new Course() { Name = "Physics 201",      Subject = Subject.Physics };
        private static readonly Course physics301       = new Course() { Name = "Physics 301",      Subject = Subject.Physics };
        private static readonly Course cooking101       = new Course() { Name = "Cooking 101",      Subject = Subject.Cooking };
        private static readonly Course cooking201       = new Course() { Name = "Cooking 201",      Subject = Subject.Cooking };
        private static readonly Course programming101   = new Course() { Name = "Programming 101",  Subject = Subject.Programming };
        private static readonly Course juggling101      = new Course() { Name = "Juggling 101",     Subject = Subject.Juggling };
        private static readonly Course juggling201      = new Course() { Name = "Juggling 201",     Subject = Subject.Juggling };
        private static readonly Course litterature101   = new Course() { Name = "Litterature 101",  Subject = Subject.Litterature }; 
        #endregion

        public static IEnumerable<Student> GetAllStudents()
        {
            yield return new Student()
            {
                FirstName = "Eric",
                LastName = "Eberlin",
                Email = "ErEb@youth-resources.org",
                CoursesTaken = { cooking101, cooking201, juggling101 },
                Exams = {
                    new Exam() {Subject=Subject.Cooking, DateTaken = DateTime.Now.AddMonths(-342), Score=87 },
                    new Exam() {Subject=Subject.Cooking, DateTaken = DateTime.Now.AddDays(-377), Score=100 },
                    new Exam() {Subject=Subject.Juggling, DateTaken = DateTime.Now.AddDays(-128), Score=100 },
                }
            };

            yield return new Student()
            {
                FirstName = "Joanna",
                LastName = "Burns",
                Email = "JoannaBurns@hotmail.com",
                CoursesTaken = { physics101, juggling101, juggling201, cooking101, litterature101 },
                Exams = {
                    new Exam() {Subject=Subject.Physics, DateTaken = DateTime.Now.AddMonths(-2), Score=90 },
                    new Exam() {Subject=Subject.Physics, DateTaken = DateTime.Now.AddDays(-34), Score=72 },
                    new Exam() {Subject=Subject.Cooking, DateTaken = DateTime.Now.AddDays(-2), Score=87 },
                    new Exam() {Subject=Subject.Litterature, DateTaken = DateTime.Now.AddDays(-12), Score=61 },
                }
            };

            yield return new Student()
            {
                FirstName = "Brian",
                LastName = "Anderson",
                Email = "BA_74_for_fun@gmail.com",
                CoursesTaken = { programming101, juggling101, cooking101},
                Exams = {
                    new Exam() {Subject=Subject.Programming, DateTaken = DateTime.Now.AddDays(-201), Score=29 },
                    new Exam() {Subject=Subject.Juggling, DateTaken = DateTime.Now.AddDays(-342), Score=16 },
                    new Exam() {Subject=Subject.Juggling, DateTaken = DateTime.Now.AddDays(-302), Score=44 },
                    new Exam() {Subject=Subject.Juggling, DateTaken = DateTime.Now.AddDays(-202), Score=100 },
                    new Exam() {Subject=Subject.Cooking, DateTaken = DateTime.Now.AddDays(-102), Score=87 },
                }
            };

            yield return new Student()
            {
                FirstName = "Charlotte",
                LastName = "Drew",
                Email = "CharlotteD@powermail.biz",
                CoursesTaken = { physics101, physics201, physics301, litterature101 },
                Exams = {
                    new Exam() {Subject=Subject.Physics, DateTaken = DateTime.Now.AddMonths(-342), Score=99 },
                    new Exam() {Subject=Subject.Physics, DateTaken = DateTime.Now.AddDays(-377), Score=72 },
                    new Exam() {Subject=Subject.Litterature, DateTaken = DateTime.Now.AddDays(-128), Score=84 },
                }
            };
        }
    }
}
using System;

namespace StudentLinq.Model
{
    public class Exam
    {
        public DateTime DateTaken { get; set; }
        public int Score { get; set; }
        public Subject Subject{ get; set; }
    }
}
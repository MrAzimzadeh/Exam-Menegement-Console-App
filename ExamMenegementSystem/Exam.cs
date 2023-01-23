using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMenegementSystem
{
    public class Exam
    {
        public int Id { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }
        public List<Student> Students { get; set; }

        public Exam(string examName, DateTime examDate)
        {

            ExamName = examName;
            ExamDate = examDate;
            Students = new List<Student>();
        
        }


    }
}
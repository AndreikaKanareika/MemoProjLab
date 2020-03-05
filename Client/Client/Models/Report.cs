using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Report
    {
        public List<Lecture> Lectures { get; set; }
        public List<Lab> Labs { get; set; }
        public List<Student> Students { get; set; }

    }

    public class Lecture
    {
        public string SubjectName { get; set; }
        public int LectureHours { get; set; }
    }

    public class Lab
    {
        public string SubjectName { get; set; }
        public int LabHours { get; set; }
    }

    public class Student
    {
        public string SubjectName { get; set; }
        public int StudentsCount { get; set; }
    }
}

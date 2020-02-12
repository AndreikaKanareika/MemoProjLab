using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class MemoResponse
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int LectureHours { get; set; }
        public int LabHours { get; set; }
        public int ControlType { get; set; }
        public int StudentsCount { get; set; }
    }
}

using System;

namespace TeacherMemo.Persistence.Abstact.Entities
{
    public class MemoEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string SubjectName { get; set; }
        public int LectureHours { get; set; }
        public int LabHours { get; set; }
        public ControlType ControlType { get; set; }
        public int StudentsCount { get; set; }
    }
}

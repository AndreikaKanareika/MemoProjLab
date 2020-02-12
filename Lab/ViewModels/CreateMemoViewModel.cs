﻿using TeacherMemo.Domain;

namespace Lab.ViewModels
{
    public class CreateMemoViewModel
    {
        public string SubjectName { get; set; }
        public int LectureHours { get; set; }
        public int LabHours { get; set; }
        public ControlType ControlType { get; set; }
        public int StudentsCount { get; set; }
    }
}

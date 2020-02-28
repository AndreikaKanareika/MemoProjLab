using System.Collections.Generic;
using TeacherMemo.Domain;

namespace TeacherMemo.Services.Abstract
{
    public interface ISubjectService
    {
        void Add(Subject item);
        void DeleteByName(string subjectName);
        Subject GetByName(string subjectName);
        IEnumerable<Subject> GetAll();
    }
}

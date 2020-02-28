using System.Collections.Generic;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Abstact
{
    public interface ISubjectRepository
    {
        void Add(SubjectEntity item);
        void DeleteByName(string subjectName);
        SubjectEntity GetByName(string subjectName);
        IEnumerable<SubjectEntity> GetAll();
        void SaveChanges();
    }
}

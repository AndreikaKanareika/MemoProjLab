using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Implementation
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly MemoContext _context;

        public SubjectRepository(MemoContext context)
        {
            _context = context;
        }

        public void Add(SubjectEntity item)
        {
            _context.Subjects.Add(item);
        }

        public void DeleteByName(string subjectName)
        {
            var entity = GetByName(subjectName);
            if (entity != null)
            {
                _context.Subjects.Remove(entity);
            }
        }

        public IEnumerable<SubjectEntity> GetAll()
        {
            return _context.Subjects;
        }

        public SubjectEntity GetByName(string subjectName)
        {
            return _context.Subjects.AsNoTracking().FirstOrDefault(x => x.Name == subjectName);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

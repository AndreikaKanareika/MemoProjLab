using System;
using System.Collections.Generic;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Abstact
{
    public interface IMemoRepository
    {
        void Add(MemoEntity item);
        void Update(MemoEntity item);
        void Delete(int id);
        MemoEntity Get(int id);
        IEnumerable<MemoEntity> GetAll();
        IEnumerable<MemoEntity> Find(Func<MemoEntity, bool> predicate);
        void SaveChanges();
    }
}

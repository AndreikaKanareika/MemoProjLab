using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Persistence.Implementation
{
    public class MemoRepository : IMemoRepository
    {
        private readonly MemoContext _context;

        public MemoRepository(MemoContext context)
        {
            _context = context;
        }

        public void Add(MemoEntity item)
        {
            _context.Memos.Add(item);
        }
        
        public void Update(MemoEntity item)
        {
            _context.Memos.Update(item);
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Memos.Remove(entity);
            }
        }

        public MemoEntity Get(int id)
        {
            return _context.Memos.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<MemoEntity> GetAll()
        {
            return _context.Memos;
        }

        public IEnumerable<MemoEntity> Find(Func<MemoEntity, bool> predicate)
        {
            return _context.Memos.Where(predicate);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

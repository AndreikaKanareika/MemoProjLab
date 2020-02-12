using System.Collections.Generic;
using TeacherMemo.Domain;

namespace TeacherMemo.Services.Abstract
{
    public interface IMemoService
    {
        Memo Add(Memo item);
     //   Memo Update(Memo item);
        void Delete(int id);
        Memo Get(int id);
        IEnumerable<Memo> GetAll();
        IEnumerable<Memo> FindInRangeByLecturesHours(int from, int to);
    }
}

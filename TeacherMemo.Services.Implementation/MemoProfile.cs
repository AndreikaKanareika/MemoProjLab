using AutoMapper;
using TeacherMemo.Domain;
using TeacherMemo.Persistence.Abstact.Entities;

namespace TeacherMemo.Services.Implementation
{
    public class MemoProfile : Profile
    {
        public MemoProfile()
        {
            CreateMap<Memo, MemoEntity>().ReverseMap();
        }
    }
}

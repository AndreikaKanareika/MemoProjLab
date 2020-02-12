using AutoMapper;
using Lab.ViewModels;
using TeacherMemo.Domain;

namespace Lab.Profiles
{
    public class MemoProfile : Profile
    {
        public MemoProfile()
        {
            CreateMap<CreateMemoViewModel, Memo>();
            CreateMap<UpdateMemoViewModel, Memo>();
            CreateMap<MemoViewModel, Memo>().ReverseMap();
        }
    }
}

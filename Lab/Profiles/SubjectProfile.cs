using AutoMapper;
using Lab.ViewModels;
using TeacherMemo.Domain;

namespace Lab.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectViewModel, Subject>().ReverseMap();
        }
    }
}

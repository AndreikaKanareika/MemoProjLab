using FluentValidation;
using Lab.ViewModels;
using TeacherMemo.Services.Abstract;

namespace Lab.Validators
{
    public class CreateMemoValidator : AbstractValidator<CreateMemoViewModel>
    {
        public CreateMemoValidator(ISubjectService subjectService)
        {
            RuleFor(x => x.SubjectName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50)
                .Must(subjectName => subjectService.GetByName(subjectName) != null);
            RuleFor(x => x.LabHours)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.LectureHours)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.StudentsCount)
                .GreaterThanOrEqualTo(0);
        }
    }
}

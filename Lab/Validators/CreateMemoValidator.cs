using FluentValidation;
using Lab.ViewModels;

namespace Lab.Validators
{
    public class CreateMemoValidator : AbstractValidator<CreateMemoViewModel>
    {
        public CreateMemoValidator()
        {
            RuleFor(x => x.SubjectName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);
            RuleFor(x => x.LabHours)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.LectureHours)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.StudentsCount)
                .GreaterThanOrEqualTo(0);
        }
    }
}

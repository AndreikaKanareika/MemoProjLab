using FluentValidation;
using Lab.ViewModels;

namespace Lab.Validators
{
    public class UpdateMemoValidator : AbstractValidator<UpdateMemoViewModel>
    {
        public UpdateMemoValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id should be greater than 0");
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

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Validators
{
    public class StudentInfoValidator : AbstractValidator<StudentDetails>
    {
        public StudentInfoValidator()
        {
            RuleFor(fn => fn.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2,20).WithMessage("Length of {PropertyName} is Invalid")
                .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(ln => ln.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 20).WithMessage("Length of {PropertyName} is Invalid")
                .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(pw => pw.Password)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} is empty")
               .Length(2, 20).WithMessage("Length of {PropertyName} is Invalid");

            RuleFor(sn => sn.StudentNumber)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} is empty")
               .Length(2, 20).WithMessage("Length of {PropertyName} is Invalid")
               .Must(BeAVaildStudentNumber).WithMessage("{PropertyName} Contains Invalid Characters");

        }

        protected bool BeAValidName(string name) 
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");

            return name.All(char.IsLetter);
        }

        protected bool BeAVaildStudentNumber(string studentNumber) 
        {
            studentNumber = studentNumber.Replace("ST", "");
            studentNumber = studentNumber.Replace("st", "");

            return studentNumber.All(char.IsDigit);
        }

    }
}

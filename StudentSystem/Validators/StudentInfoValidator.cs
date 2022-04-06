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
               .Length(8, 20).WithMessage("Length of {PropertyName} is Invalid")
               .Must(BeAValidPassword).WithMessage("{PropertyName} is not valid");

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

        protected bool BeAValidPassword(string password)
        {
            int validConditions = 0;
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                if (password.IndexOfAny(special) == -1) return false;
            }
            return true;
        }

    }
}

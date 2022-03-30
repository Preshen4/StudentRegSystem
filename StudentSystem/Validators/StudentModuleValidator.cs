using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Validators
{
    public class StudentModuleValidator: AbstractValidator<StudentModules>
    {
        public StudentModuleValidator() 
        {
            RuleFor(m => m.Modules)
                .NotEmpty().WithMessage("Please select modules")
                .Must(BeAValidNumberOfModules).WithMessage("Can't select more than 12 modules");
        }

        protected bool BeAValidNumberOfModules(string modules) 
        {
            char ch = ',';

            int freq = modules.Where(x => (x == ch)).Count();
            if (freq<=13)
            {
                return true;
            }

            return false;
        }
    }
}

using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p=>p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).Length(10).When(p=>p.LastName.Length == 10);
            RuleFor(p => p.FirstName).Must(StartWithA).WithMessage("This must starts with the letter 'A'");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

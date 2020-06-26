using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("first name is required")
                .MaximumLength(200).WithMessage("First name cannot over 200 characters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required")
                .MaximumLength(200).WithMessage("Last Name cannot over 200 characters");

            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot greater than 100 year");//sô tuổi không thể lớn hơn 100 năm trước

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") // email phải theo format như này
                .WithMessage("Email format not match");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is not requied");//không cho phép username rỗng nếu rỗng báo mess

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is not requied")
                .MinimumLength(5).WithMessage("Password is at least 6 characters");

            RuleFor(x => x).Custom((request, context) =>
                  {
                      if(request.Password!= request.confirmPassword)
                      {
                          context.AddFailure("Confirm password is not match");
                      }
                  });
        }
    }
}

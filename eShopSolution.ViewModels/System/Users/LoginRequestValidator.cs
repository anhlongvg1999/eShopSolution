using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is not requied");//không cho phép username rỗng nếu rỗng báo mess
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is not requied")
                .MinimumLength(5).WithMessage("Password is at least 6 characters");
        }
    }
}

using Bogus;
using FluentValidation;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Application.Interfaces;

namespace Transflo.Driver.Api.Validators
{
    public class PostDriverValidator : AbstractValidator<PostDriverDto>
    {
        public PostDriverValidator(IDriverService driverService) 
        {

            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();

            RuleFor(m => m.Email).NotEmpty().EmailAddress();
        }
    }
}

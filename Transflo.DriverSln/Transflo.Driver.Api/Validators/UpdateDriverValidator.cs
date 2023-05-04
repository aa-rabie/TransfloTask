using Bogus;
using FluentValidation;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Application.Interfaces;

namespace Transflo.Driver.Api.Validators
{
    public class UpdateDriverValidator : AbstractValidator<UpdateDriverDto>
    {
        
        public UpdateDriverValidator() 
        {

           RuleFor(m => m.GetDriverId()).NotEmpty();
            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();

            RuleFor(m => m.Email).NotEmpty().EmailAddress();
        }
    }
}

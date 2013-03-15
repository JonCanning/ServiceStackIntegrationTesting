using ServiceStack.FluentValidation;
using ServiceStackApp.Dtos;

namespace ServiceStackApp.Validators
{
    public class HelloValidator : AbstractValidator<Hello>
    {
        public HelloValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please provide a name");
        }
    }
}
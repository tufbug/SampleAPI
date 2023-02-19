using FluentValidation;
using Puffin.DataAccess.Entities;

namespace Puffin.Validators
{
	public class FeatherValidator : AbstractValidator<Feather>
	{
		public FeatherValidator()
		{
			RuleFor(o => o.Id).NotNull().NotEmpty();
			RuleFor(o => o.Name).NotNull().NotEmpty().MinimumLength(3);
		}
	}
}


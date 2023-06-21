using FluentValidation;
using ParentWithChildData.Models;

namespace ParentWithChildData.Validation;

public class ItemFormValidator : AbstractValidator<ItemForm>
{
    public ItemFormValidator()
    {
        RuleFor(i => i.Value).NotEmpty().WithMessage("Value is required");
    }
}

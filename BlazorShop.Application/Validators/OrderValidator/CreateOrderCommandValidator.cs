﻿namespace BlazorShop.Application.Validators.OrderValidator
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(v => v.UserEmail)
                .MaximumLength(100).WithMessage("Maximum length exceeded")
                .NotEmpty().WithMessage("UserEmail must not be empty")
                .NotNull().WithMessage("UserEmail must not be null");

            RuleFor(v => v.OrderDate)
                .GreaterThanOrEqualTo(DateTime.Now.AddDays(-1)).WithMessage("Date must be greater or equal with Current Date")
                .NotEmpty().WithMessage("OrderDate must not be empty")
                .NotNull().WithMessage("OrderDate must not be null");

            RuleFor(v => v.LineItems)
                .MaximumLength(10000).WithMessage("Maximum length exceeded")
                .NotEmpty().WithMessage("LineItems must not be empty")
                .NotNull().WithMessage("LineItems must not be null");

            RuleFor(v => v.AmountTotal)
                .GreaterThan(0).WithMessage("AmountTotal must be greater than 0");
        }
    }
}

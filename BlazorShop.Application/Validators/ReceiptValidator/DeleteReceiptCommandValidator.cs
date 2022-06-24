﻿// <copyright file="DeleteReceiptCommandValidator.cs" company="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Application.Validators.ReceiptValidator
{
    /// <summary>
    /// A model to update a cart.
    /// </summary>
    public class DeleteReceiptCommandValidator : AbstractValidator<DeleteReceiptCommand>
    {
        /// <summary>
        /// .
        /// </summary>
        public DeleteReceiptCommandValidator()
        {
            RuleFor(v => v.Id)
                .GreaterThan(0).WithMessage("Id must be greater than 0");
        }
    }
}

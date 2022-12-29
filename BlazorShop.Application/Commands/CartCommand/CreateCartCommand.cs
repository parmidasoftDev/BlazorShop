﻿// <copyright file="CreateCartCommand.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Application.Commands.CartCommand
{
    /// <summary>
    /// A model to create a cart.
    /// </summary>
    public class CreateCartCommand : IRequest<RequestResponse>
    {
        /// <summary>
        /// The id of the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The id of the clothe.
        /// </summary>
        public int ClotheId { get; set; }

        /// <summary>
        /// The name of the cart.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The price of the cart.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The amount of the cart.
        /// </summary>
        public int Amount { get; set; }
    }
}
